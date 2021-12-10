import day06.LanternFish as LanternFish


def test_count_fishes():
    testdata = "3,4,3,1,2"
    assert LanternFish.count_fishes(testdata) == 5934
