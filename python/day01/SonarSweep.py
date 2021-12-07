import logging


def number_of_depth_increases(measurements):
    # logging.info(measurements)
    count = 0
    prev_measurement = 1000 * 1000
    for measurement in map(int, measurements):
        if measurement > prev_measurement:
            count += 1
        prev_measurement = measurement

    return count
