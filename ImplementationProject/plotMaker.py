import numpy as np
import matplotlib.pyplot as plt

# load data
t = 18
file = "./Experiments/experiment" + (str)(t) + ".csv"
data = np.loadtxt(file, delimiter=";")
X = data[:,-1].reshape((len(data[:,-1]),1))
sortedX = sorted(X)
S = np.full((100,1), 100000)
xNumbers = np.arange(0,100)

# Makes first plot
plt.scatter(xNumbers,sortedX, 10)
plt.axhline(y=S[0], color='r', linestyle='-')
plt.ylabel("Estimates")
plt.xlabel("X")
plt.title('Estimates, t = %i' %t)
plt.show()

# Calculates mean square error
def mse(X, S):
    s = 0.0
    for i in range (100):
        s += (X[i]-S[i])**2/100
    return s

# Prints mean and mean square variance
actualVariance = 2*S[0]**2/2**t
print("Mean: " + (str)(np.mean(X)))
print("Diff: " + (str) (abs(S[0]-np.mean(X))/S[0]*100))
print("MSE : %16f" % mse(X,S))
print("Var:  %16f" % actualVariance)
print("Diff: %16f" % (abs(actualVariance-mse(X,S))/actualVariance*100))

# Groups data
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

# Gets median of all groups
M = []
for x in G:
    M.append((np.mean(x)))
sortedM = sorted(M)
mNumbers = np.arange(0,9)

# Plots
plt.ticklabel_format(useOffset=False)
plt.scatter(mNumbers,sortedM)
plt.axhline(y=S[0], color='r', linestyle='-')
plt.ylabel("Estimates")
plt.xlabel("M")
plt.title('Median estimates, t = %i' %t)
plt.show()
