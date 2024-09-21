def binary(x):
    z = 0
    for a, b in enumerate(reversed(x.strip())):
        if b == "1":
            z += 2**a
    return z

print(binary(input()))
