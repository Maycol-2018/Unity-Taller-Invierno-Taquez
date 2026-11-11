# ❄️ Escena Invernal de Rescate - Unity 3D

Proyecto desarrollado para el taller práctico del módulo **Composición de Escenas y Control de Transformaciones**. Consiste en una narrativa visual en Unity 3D que representa una patrulla de policía atrapada y semienterrada en una tormenta de nieve con el motor encendido y luces de emergencia activas.

---

## 📷 Vista Previa

<img width="1858" height="1002" alt="image" src="https://github.com/user-attachments/assets/efc5c043-68ce-4a87-874e-4bc2888e51a7" />


🎥 **[Haz clic aquí para ver el video de demostración](https://drive.google.com/file/d/1qlBQISRCDIgDVNuOnFdYl11-NGaHARL1/view?usp=sharing)**

---

## 🛠️ Características Principales

* **Composición 3D y Terreno:** Creación de ambiente invernal utilizando un terreno con capas de nieve y modelo de vehículo posicionado en coordenadas negativas para simular el hundimiento.
* **Iluminación Ambiental y Sirenas:** Luz direccional nocturna (`Moon_Light`) combinada con luces *Spot* de emergencia en color rojo y azul.
* **Script de Rotación (`SirenRotation.cs`):** Control por código C# en el eje local (`Time.deltaTime`) para la rotación fluida e independiente de framerate de las luces de emergencia.
* **Sistemas de Partículas Atmosféricos:**
  * `Global_Blizzard`: Tormenta de nieve continua en toda la escena.
  * `Exhaust_Smoke`: Humo de escape del motor saliendo por el tubo trasero.

---

## 🏗️ Jerarquía del Proyecto (10 Objetos Principales)

1. `Main Camera`
2. `Moon_Light`
3. `Snow_Terrain`
4. `Police_Car` (Objeto Padre)
   * `Car Mesh`
   * `Siren_Pivot` (Contiene `SirenRotation.cs`)
     * `Red_Light`
     * `Blue_Light`
   * `Exhaust_Smoke` (Particle System)
5. `Global_Blizzard` (Particle System)

---

## 💻 Tecnologías Utilizadas

* **Unity 3D** (Versión 2022.3 LTS o superior)
* **C#** (Scripting de transformaciones)
* **Git & GitHub** (Control de versiones con commits atómicos)
