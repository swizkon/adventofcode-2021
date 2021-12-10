import day01.SonarSweep as SonarSweep
import day06.LanternFish as LanternFish


def main():
    print("main")

    # _day01_a()
    _day06_a()


def _day01_a():
    print("_day01_a")

    input = _read_file('day01')

    print('SonarSweep.number_of_depth_increases')
    print(SonarSweep.number_of_depth_increases(input))


def _day06_a():
    input = _read_file_as_string('day06')

    print('LanternFish.count_fishes')
    print(LanternFish.count_fishes(input))


def _read_file_as_string(day):
    file1 = open('../input-' + day + '.txt', 'r')
    return file1.read()


def _read_file(day):
    file1 = open('../input-' + day + '.txt', 'r')
    return file1.readlines()


if __name__ == '__main__':
    main()
