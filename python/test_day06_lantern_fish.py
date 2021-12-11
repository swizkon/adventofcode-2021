import day06.LanternFish as LanternFish


def test_count_fishes_80_days():
    testdata = "3,4,3,1,2"
    assert LanternFish.count_fishes(testdata, 80) == 5934


def test_count_fishes_256_days():
    testdata = "3,4,3,1,2"
    assert LanternFish.count_fishes(testdata, 256) == 26984457539


# 26984457539