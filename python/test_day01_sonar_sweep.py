
import day01.SonarSweep as SonarSweep


def func(x):
    return x + 1


def test_answer():
    testdata = [199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263]
    assert SonarSweep.number_of_depth_increases(testdata) == 7
