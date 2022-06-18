# Exercise 
_______
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
_______
** Solution 
_______
Объявляем два метода и сразу определяем их длину. Первый массив будет определяет длину содержащий исходные данные. второй равен длине первого массива.
Указываем метод, где в цикле проводится проверка условия (длинна искомова массива <= 3), в случае положительного выполнения указанного условия, результат записывается в постоянную переменную count, что позволяет проводить выборку искомых элементов из первого массива и записывать их во второй. Затем count увеличивается на 1 и возвращается к циклу for. где проводится повторная проверка до длине всего массива.
Выводим полученный результат.# readme
