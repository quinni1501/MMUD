import numpy as np
import matplotlib as plt
x = np.linspace(1,20,15)
np.random.seed(1)
y = np.random.randint(0,10,15)
plt.plot(x, y)
plt.legend(['data points'])
plt.show()
