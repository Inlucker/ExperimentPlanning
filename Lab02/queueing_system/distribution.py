from numpy import random as nr
from . import exceptions as ex
import math


class Uniform:
    def __init__(self, a, b):
        if not 0 <= a <= b:
            raise ex.ParameterError("Parameters must be 0 <= a <= b")
        self._a = a
        self._b = b

    def generate(self):
        return nr.uniform(self._a, self._b)

class Weibull:
    def __init__(self, a, lamb, mx):
        self._a = a
        self._lamb = lamb
        self.mx = mx

    def generate(self):
        # cur_time = -1 

        cur_time = self._lamb*nr.weibull(self._a)
        while cur_time < 0 or cur_time > 2*self.mx:
            cur_time = self._lamb*nr.weibull(self._a)

        return cur_time
        # return self._lamb*nr.weibull(self._a)

class Normal:
    def __init__(self, mu, sigma):
        self._mu = mu
        self._sigma = sigma

    def generate(self):
        cur_time = nr.normal(self._mu, self._sigma)
        # while cur_time < 0:
        #     cur_time = nr.normal(self._mu, self._sigma)
        while cur_time < 0 or cur_time > 2*self._mu:
            cur_time = nr.normal(self._mu, self._sigma)

        return cur_time

class Rayleigh:
    def __init__(self, sig):
        if not 0 <= sig:
            raise ex.ParameterError("Parameters must be 0 <= sigma")
        self._sigma = sig

    def generate(self):
        # cur_time = math.sqrt(-2*self._sigma*self._sigma * math.log(1- rnd.NextDouble()))
        cur_time = nr.rayleigh(self._sigma)
        #while cur_time < 0 or cur_time > 2*self._sigma:
        #    cur_time = nr.rayleigh(self._sigma)
        return cur_time
