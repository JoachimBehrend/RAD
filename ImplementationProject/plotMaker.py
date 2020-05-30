import numpy as np
import matplotlib.pyplot as plt

# load data
t10_data = np.loadtxt("experiment20.csv", delimiter=";")
X = t10_data[:,-1].reshape((len(t10_data[:,-1]),1))
sortedX = sorted(X)
S = np.full((100,1), 1000000)

xNumbers = np.arange(0,100)

# plt.scatter(xNumbers,sortedX, 10)
# plt.axhline(y=1000000, color='r', linestyle='-')
# plt.ylabel("Estimates")
# plt.xlabel("X")
# plt.show()


def mse(X, S):
    s = 0.0
    for i in range (100):
        s += (X[i]-S[i])**2/100
    return s

var = 2*1000000**2/2**20
# print("Mean-square error: %16f" % mse(X,S))
# print("Var: %16f" % var)
# print("Diff: %16f" % (var-mse(X,S)))
# print("Mean: " + (str)(np.mean(X)))
# print("Diff: " + (str)(1000000-np.mean(X)))

G = []
G.append(X[:11])
G.append(X[11:22])
G.append(X[22:33])
G.append(X[33:44])
G.append(X[44:55])
G.append(X[55:66])
G.append(X[66:77])
G.append(X[77:88])
G.append(X[88:99])

M = []
for x in G:
    M.append((np.mean(x)))

print(M)
sortedM = sorted(M)
mNumbers = np.arange(0,9)

plt.ticklabel_format(useOffset=False)
plt.scatter(mNumbers,sortedM)
plt.axhline(y=1000000, color='r', linestyle='-')
plt.ylabel("Estimates")
plt.xlabel("M")
plt.show()
