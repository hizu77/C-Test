# Описание

> Код написан на языке **C# .net8.0**
> 

> Исходный код можно посмотреть тут: [ссылка на git hub](https://github.com/hizu77/C-Test)
> 

> Файл **exe** можно посмотреть тут: [ссылка](https://drive.google.com/drive/folders/1rlKCKwX2-zsanqiHiy7klI2h-WA8CaTr?usp=drive_link)
> 

## **Запуск программы**

1. Вводим точность
2. Выбираем вариант перевода : 
    1. Декартова - полярная
    2. Полярная - Декартова
    3. Декартова - Сферическая
    4. Сферическая - Декартова
3. Вводим координаты

Угол вводится и выводится в **градусах > 0.**

## Описание формул

1. Из декартовой в полярную $(x,y) \rightarrow (r,\theta)$
    
    $r = \sqrt{x^2+y^2}$
    
    $\theta=arctg{\frac{y}{x}}$
    
    При $x = 0$ и $y=0$ : $\theta$ - не определено.
    
2. Из полярной в декартовую $(r,\theta) \rightarrow (x,y)$
    
    $x=r\cos \theta$
    
    $y=r\sin \theta$
    
3. Из сферической в декартову $(r, \theta, \phi) \rightarrow (x,y,z)$
    
    $x = r\sin(\theta)\cos(\phi)$
    
    $y=r\sin(\theta)\sin(\phi)$
    
    $z=r\cos(\theta)$
    
4. Из декартовой в сферическую $(x, y,z) \rightarrow(r,\theta, \phi)$
    
    $r=\sqrt{x^2+y^2+z^2}$
    
    $\theta=\arccos{\frac{z}{r}}$
    
    $\phi=arctg{\frac{y}{x}}$
