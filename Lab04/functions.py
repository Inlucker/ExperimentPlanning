from Modeller import Modeller
from EventGenerator import Generator
from Distributions import  RayleighDistribution, Exponentialistribution, UniformDistribution
from Processor import Processor
import math
from matplotlib import pyplot
from numpy import arange 

def modelling(clients_number, clients_proccessed, lambda_coming, lambda_obr, lambda_coming2=None, lambda_obr2=None):
    '''
    sigma = (1/lambda_coming) * (math.pi / 2) ** (-1/2)
    sigma2 = sigma 
    if lambda_coming2: 
        sigma2 = (1/lambda_coming2) * (math.pi / 2) ** (-1/2)


    lam = (1/lambda_obr)
    lam2 = lam
    if lambda_obr2:
        lam2 = (1/lambda_obr2)
    '''
    sig1, a1, b1, sig2, a2, b2 = param_convert(lambda_coming, lambda_obr, lambda_coming2, lambda_obr2)

    generators = [
        Generator(
            RayleighDistribution(sig1),
            clients_number,
            0
        ), 
        Generator(
            RayleighDistribution(sig2),
            clients_number,
            1
        ), 
    ]

    operators = [
            Processor(
                [UniformDistribution(a1, b1),
                UniformDistribution(a2, b2)]
            ),
        ]

    for generator in generators: 
        generator.receivers = operators.copy()

    model = Modeller(generators, operators)
    result = model.event_mode(clients_proccessed)
    print("Загрузка системы(расчетная): ", lambda_coming/lambda_obr, 
    "\nВремя работы:", result['time'], 
    "\nСреднее время ожидания: ", result['wait_time_middle'], 
    "\nКоличество обработанных заявок", clients_proccessed)
    return result

def param_convert(gen_intensity1, serv_intensity1, gen_intensity2, serv_intensity2, serv_scatter1=0, serv_scatter2=0):
    sig1, sig2 = -1, -1
    a1, a2 = -1, -1
    b1, b2 = -1, -1
    k_step = 1
    k = k_step
    serv_k = 2 * (serv_intensity1 + serv_intensity2) / (gen_intensity1 + gen_intensity2)
    serv1_ratio = serv_intensity1 / (serv_intensity1 + serv_intensity2)
    serv2_ratio = serv_intensity2 / (serv_intensity1 + serv_intensity2)
    while (a1 < 0 or b1 < 0 or sig1 < 0 or a2 < 0 or b2 < 0 or sig2 < 0):
        sig1 = k * serv_k * serv1_ratio * math.sqrt(2 / math.pi)
        dif = serv_scatter1 * math.sqrt(12);
        a1 = k * 1 - dif / 2;
        b1 = k * 1 + dif / 2;

        sig2 = k * serv_k * serv2_ratio * math.sqrt(2 / math.pi)
        dif = serv_scatter2 * math.sqrt(12);
        a2 = k * 1 - dif / 2;
        b2 = k * 1 + dif / 2;

        k += k_step

    return sig1, a1, b1, sig2, a2, b2

def view(start, end, N):
    print(start, end, N)
    Xdata = list()
    Ydata = list()

    lambda_obr = 100
    k = 2

    for lambda_coming in arange(int(start * 100), int(end * 100)/2, 1):
            result = modelling(
                clients_number=N+1000,
                clients_proccessed=N, 
                lambda_coming=lambda_coming,
                lambda_obr=lambda_obr
            )
            Xdata.append(lambda_coming*2/lambda_obr)
            Ydata.append(result['wait_time_middle'])

    pyplot.title('Среднее время ожидания')
    pyplot.grid(True)
    pyplot.plot(Xdata, Ydata)
    pyplot.xlabel("Коэффициент загрузки")
    pyplot.ylabel("Среднее время пребывания в очереди")
    pyplot.show()