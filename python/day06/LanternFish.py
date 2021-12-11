
# calc the spawn in a factorial way would be nice in erlang or elixir...

def count_fishes(input, days):
    vals = list(map(int, input.split(',')))

    # Only need to calc for each unique
    unique_ages = list(set(vals))

    result = 0

    for unique_age in unique_ages:
        spawn = _calc_spawn([unique_age], days)
        # Multiply the result with the number of occurences in the input...
        result += spawn * vals.count(unique_age)

    return result


def _calc_spawn(fishes, days_left):
    if days_left < 1:
        return len(fishes)

    next_fishes = []

    for fish in fishes:
        if fish == 0:
            next_fishes.append(6)
            next_fishes.append(8)
        else:
            next_fishes.append(fish - 1)

    return _calc_spawn(next_fishes, days_left - 1)

# Need to do some caching for the next level