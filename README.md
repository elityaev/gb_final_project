# Итоговая проверочная работа

### Задача.

> ___Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше, либо равна 3 символам. Певоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма___.    

### Решение.

Задача решена с помощью 3х функций:

1. Функция FillArray(int size) принимает аргументом размер массива и заполняет его данными вводимыми с клавиатуры и возвращает массив(далее исходный массив), заполненый элементами в виде строк.

2. Функция GetLengthNewArray(string[] arr) принимает исходный массив и возвращает количество элементов в массиве, длина которых <= 3.   

3. Функция CreateNewArray( string[] arr, int size) принимает исходный массив и результат вычислений функции GetLengthNewArray(string[] arr) в качестве размера нового массива, который создается в теле функции и заполняется элементами из исходного массива, длина которых <= 3.

---
---

**Автор**

**Литяев Евгений**
