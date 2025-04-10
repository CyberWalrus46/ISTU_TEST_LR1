import json
import random

def overflow(a, b):
    INT_MAX = 2147483647
    INT_MIN = -2147483648
    if a == 0 or b == 0:
        return False  # Умножение на 0 не приведет к переполнению
    if a > 0:
        if b > 0:
            return a > (INT_MAX / b)  # Проверка на положительное переполнение
        else:
            return b < (INT_MIN / a)  # Проверка на отрицательное переполнение
    else:
        if b > 0:
            return a < (INT_MIN / b)  # Проверка на отрицательное переполнение
        else:
            return a != 0 and b < (INT_MAX / a)  # Проверка на положительное переполнение

# print(overflow(612754902, 471))

def transform_array(input):
    input_array = input.copy()
    product = 1
    errors = []

    if input_array is None:
        return [], 0, ["Input array is null."]
    if len(input_array) == 0:
        return [], 0, ["Input array is empty."]
    if len(input_array) > 1024:
        errors.append("Too many elements. Array truncated to 1024")
        input_array = input_array[0:1024]  # Урезаем массив до 1024 элементов

    for i in range(len(input_array)):
        if (overflow(product, input_array[i])):
            product = 0
            errors.append(f"The product overflowed when multiplied with {input_array[i]} at index {i}. The product is set to 0.")
        else:
            product = product * input_array[i]
        if (product == 0):
            break

    for i in range(len(input_array)):
        if input_array[i] < 0 and input_array[i] % 2 != 0:
            perem = (input_array[i] - product) * (input_array[i] - product)
            if (perem > 2147483647 or perem < -2147483648):
                errors.append(f"Переполнение по индексу {i} для значения {input_array[i]}.")
            else:
                input_array[i] = perem

    return input_array, product, errors

def generate_test_case(name, array, expected_array, expected_product, expected_errors):
    return {
        "name": name,
        "array": array,
        "expectedArray": expected_array,
        "expectedProduct": expected_product,
        "expectedErrors": expected_errors
    }

def generate_test_cases():
    test_cases = []
    max_size = 1024

    # InfoGraph
    # tv1
    test_cases.append(generate_test_case(f"TV1", None, [], 0, ["Input array is null."]))

    # tv2
    test_cases.append(generate_test_case(f"TV2", [], [], 0, ["Input array is empty."]))

    # tv7
    arr = [random.randrange(-1000, 1000, 2) for _ in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"TV7", arr, expected_array, expected_product, expected_errors))

    # tv8
    arr = [random.randrange(-1000, 1000) for _ in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"TV8", arr, expected_array, expected_product, expected_errors))

    # tv9
    arr = [random.randrange(-1000000, 1000000) for _ in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"TV9", arr, expected_array, expected_product, expected_errors))



    # PotokGraph
    # pv1
    arr = [random.randrange(-1000, 1000) for _ in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"PV1", arr, expected_array, expected_product, expected_errors))


    # pv2
    arr = [random.randrange(-1000000, 1000000) for _ in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"PV2", arr, expected_array, expected_product, expected_errors))


    # Equialence
    # eq1
    test_cases.append(generate_test_case(f"EQ1", None, [], 0, ["Input array is null."]))

    # eq2
    test_cases.append(generate_test_case(f"EQ2", [], [], 0, ["Input array is empty."]))

    # eq3
    arr = [random.randrange(-1000, 1000)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ3", arr, expected_array, expected_product, expected_errors))

    # eq4
    arr = [random.randrange(-1000, 1000) for i in range(random.randrange(1, 1024))]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ4", arr, expected_array, expected_product, expected_errors))

    # eq5
    arr = [0]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ5", arr, expected_array, expected_product, expected_errors))

    # eq6
    arr = [1]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ6", arr, expected_array, expected_product, expected_errors))

    # eq7
    arr = [-1]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ7", arr, expected_array, expected_product, expected_errors))

    size = 1
    # eq8
    arr = [2147483647]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ8", arr, expected_array, expected_product, expected_errors))

    # eq9
    arr = [-2147483648]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ9", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq10
    arr = [random.randrange(-1000, 1000) for i in range(size)]
    arr.append(2147483647)
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ10", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq11
    arr = [random.randrange(-1000, 1000) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ11", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq12
    arr = [random.randrange(-1000, 1000) for i in range(size)]
    arr.append(-2147483648)
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ12", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq13
    arr = [random.randrange(-1000, 1000) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ13", arr, expected_array, expected_product, expected_errors))

    # eq14
    arr = [random.randrange(-1000, 1000) for i in range(1023)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ14", arr, expected_array, expected_product, expected_errors))

    # eq15
    arr = [random.randrange(-1000, 1000) for i in range(1024)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ15", arr, expected_array, expected_product, expected_errors))

    # eq16
    arr = [random.randrange(-1000, 1000) for i in range(1025)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ16", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq17
    arr = [0 for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ17", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq18
    arr = [random.randrange(1, 1000) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ18", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq19
    arr = [random.randrange(-1000, -1) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ19", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq20
    arr = [2 for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ20", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq21
    arr = [-2 for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ21", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq22
    arr = [3 for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ22", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq23
    arr = [-3 for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ23", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq24
    arr = [random.randrange(2, 1000, 2) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ24", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq25
    arr = [random.randrange(1, 1000, 2) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ25", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq26
    arr = [random.randrange(-1000, -2, 2) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ26", arr, expected_array, expected_product, expected_errors))

    size += 68
    # eq27
    arr = [random.randrange(-999, -1, 2) for i in range(size)]
    expected_array, expected_product, expected_errors = transform_array(arr)
    test_cases.append(generate_test_case(f"EQ27", arr, expected_array, expected_product, expected_errors))

    return test_cases

def save_to_json(test_cases, filename='test_cases.json'):
    with open(filename, 'w') as f:
        json.dump(test_cases, f, indent=5)


test_cases = generate_test_cases()
save_to_json(test_cases)