from .distribution import Uniform, Weibull, Normal, Rayleigh
from .generator import Generator
from .processor import Processor


class Modeller:
    def __init__(self, rayleigh_sig, uniform_a, uniform_b):
        # self._generator = Generator(Uniform(uniform_a, uniform_b))
        self._generator = Generator(Rayleigh(rayleigh_sig))
        # self._processor = Processor(Weibull(weibull_a, weibull_lamb, m))
        # self._processor = Processor(Normal(weibull_a, weibull_lamb))
        self._processor = Processor(Uniform(uniform_a, uniform_b))
        self._generator.add_receiver(self._processor)
        self._avg_gen_t = 0
        self._avg_gen_req_n = 0
        self._avg_proc_t = 0
        self._avg_proc_req_n = 0

    def event_based_modelling(self, end_time):
        generator = self._generator
        processor = self._processor 

        gen_period = generator.next_time()
        self._avg_gen_t += gen_period
        self._avg_gen_req_n += 1
        proc_period = processor.next_time()
        self._avg_proc_t += proc_period
        self._avg_proc_req_n += 1
        proc_period += gen_period

        start_times = [gen_period]
        end_times = [proc_period]

        cur_time = 0
        queue = 0

        # while cur_time < end_time:
        #     if gen_time <= proc_time:
        #         gen_time += generator.next_time()
        #         start_times.append(gen_time)
        #         cur_time = gen_time
        #         queue += 1
        #     elif queue != 0:
        #         proc_time = gen_time + processor.next_time()
        #         end_times.append(proc_time)
        #         queue -= 1
            
                

        while cur_time < end_time:
        #while self._avg_gen_req_n < end_time:
            if gen_period <= proc_period:
                generator.emit_request()
                tmp = generator.next_time()
                self._avg_gen_t += tmp
                self._avg_gen_req_n += 1
                gen_period += tmp
                cur_time = gen_period
                start_times.append(cur_time)
            if gen_period >= proc_period:
                processor.process()
                if processor.current_queue_size > 0:
                    tmp = processor.next_time()
                    self._avg_proc_t += tmp
                    self._avg_proc_req_n += 1
                    proc_period += tmp
                else:
                    tmp = processor.next_time()
                    self._avg_proc_t += tmp
                    self._avg_proc_req_n += 1
                    proc_period = gen_period + tmp
                cur_time = proc_period
                end_times.append(cur_time)
        
        avg_wait_time = 0
        # print(len(start_times), len(end_times))
        print ("avg_gen_time = ", self._avg_gen_t/self._avg_gen_req_n, \
               "avg_proc_time = ", self._avg_proc_t/self._avg_proc_req_n)
        request_count = min(len(end_times), len(start_times))

        tmp = []
        for i in range(request_count):
            avg_wait_time += end_times[i] - start_times[i]
            tmp.append(end_times[i] - start_times[i])
        
        if request_count > 0:
            avg_wait_time /= request_count
        # print("start_times", start_times)
        # print("end_times", end_times)
        # print(tmp)

        actual_lamb = self._generator.get_avg_intensity()
        actual_mu = self._processor.get_avg_intensity()
        ro = actual_lamb/actual_mu
        #print("actual_ro", actual_lamb, actual_mu)

        return ro, avg_wait_time

    def time_based_modelling(self, request_count, dt):
        generator = self._generator
        processor = self._processor

        gen_period = generator.next_time()
        proc_period = gen_period + processor.next_time()
        current_time = 0

        while processor.processed_requests < request_count:
            if gen_period <= current_time:
                generator.emit_request()
                gen_period += generator.next_time()
            if current_time >= proc_period:
                processor.process()
                if processor.current_queue_size > 0:
                    proc_period += processor.next_time()
                else:
                    proc_period = gen_period + processor.next_time()
            current_time += dt

        return (processor.processed_requests, processor.reentered_requests,
                processor.max_queue_size, round(current_time, 3))
