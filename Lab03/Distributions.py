
from numpy.random import rayleigh, exponential, uniform
import numpy as np

class RayleighDistribution:
    def __init__(self, sigma: float):
        self.sigma = sigma

    def generate(self):
        return rayleigh(self.sigma)

class Exponentialistribution:
    def __init__(self, lambdaParam: float):
        self.lambdaParam = lambdaParam

    def generate(self):
        return exponential(self.lambdaParam)

class UniformDistribution:
    def __init__(self, a, b):
        self._a = a
        self._b = b

    def generate(self):
        return uniform(self._a, self._b)