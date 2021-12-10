from rx import of, operators as op


def count_fishes(input):
    vals = input.split(',')
    unique_ages = list(set(vals))
    print(input)

    of(unique_ages).pipe(
        op.distinct(lambda s: s),
        #op.map(lambda s: len(s)),
        #op.filter(lambda i: i >= 5)
    ).subscribe(lambda value: print("Received {0}".format(value)))

    return 12345


def calculate_unique_ages(input):

    print(input)

    return 12345
