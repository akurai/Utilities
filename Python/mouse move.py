import time

import mouse


while (True):
    mouse.move(1000, 1000, absolute=True, duration=1)
    time.sleep(2)

print("end of the line....")