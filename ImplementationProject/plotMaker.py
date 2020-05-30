import numpy as np
import matplotlib.pyplot as plt

# load data
t10_data = np.loadtxt("experiment10.csv", delimiter=",")
X = t10_data[:,-1].reshape((len(t10_data[:,-1]),1))
X = sorted(X)
S = np.full((100,1), 1000000)

numbers = np.arange(0,100)

plt.scatter(numbers,X, 10)
plt.axhline(y=1000000, color='r', linestyle='-')
plt.ylabel("Estimates")
plt.xlabel("X")
# plt.show()


def mse(X, S):
    s = 0.0
    for i in range (100):
        s += (X[i]-S[i])**2/100
    return s

var = 2*1000000**2/2**10
print("Mean-square error: %16f" % mse(X,S))
print("Var: %16f" % (var-mse(X,S)))
print("Mean: " + (str)(np.mean(X)))
