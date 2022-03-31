# Shooting-range-test-task
 
Physics/Генерация

[ENG]
Shoot range with target/bullet generation. Control via joystick and button.
Player stands in scene, cannot move, only rotate his camera with joystick. 
When the player presses the button, the projectile flies in the direction of the camera.
1. Targets - set of physical object(Cube or ball) that assembled in geometric figure(Pyramid or Cube).
Target must hold its shape until bullet hit. When projectile hits, target must perform realistic reaction.
2. Targets generates around a players at a given distance.
3. Projectile - physical object(Ball or cube, chosen by random before shoot). When hits the target
blow up with given radius.
Objects inside the radius are destroyed and those outside the radius receive a boost.

[RUS]
Тир с генерацией мишеней/снарядов. Управление с помощью экранного
джойстика и кнопки.
Игрок стоит в сцене, не может двигаться, но может поворачиваться из
стороны в сторону и смотреть вверх/вниз, при нажатии на кнопку
генерируется снаряд(физический объект) который вылетает из центра
камеры в направлении взгляда.
1. Каждая мишень - набор физических объектов(шар, куб) собранных в
геометрическую фигуру(пирамида, куб). Всего 4-е типа мишеней. Мишень
должна сохранять форму до попадания снаряда. При попадании снаряда
должна реагировать по физике.
2. Мишени генерируются вокруг игрока на заданном отдалении.
3. Снаряд - физических объект(шар, куб. Выбирается случайно при
выстреле). При попадании в мишень взрывается с заданным радиусом.
Объекты внутри радиуса уничтожаются, а за пределами радиуса получают
импульс.
