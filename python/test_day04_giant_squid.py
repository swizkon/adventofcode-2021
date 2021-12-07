
import day04.GiantSquid as GiantSquid

def func(x):
    return GiantSquid.sum(10,25)


def test_answer():
    assert func(3) == 5