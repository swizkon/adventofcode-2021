import day01.SonarSweep as SonarSweep


def main():
    print("main")

    _day01_a()


def _day01_a():
    print("_day01_a")

    input = _read_file('day01')

    print('SonarSweep.number_of_depth_increases')
    print(SonarSweep.number_of_depth_increases(input))


def _read_file(day):
    file1 = open('../input-' + day + '.txt', 'r')
    return file1.readlines()


if __name__ == '__main__':
    main()
