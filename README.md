![Work in Progress](https://img.shields.io/badge/Status-Work%20in%20Progress-yellow)

# Payment for Freedom - Unity 2D Platformer

**Language:** [English](#english) | [Türkçe](#türkçe)

---

<a id="english"></a>
## 🇬🇧 English

### 🎮 About the Project
"Payment for Freedom" is a 2D platformer game developed using Unity and C#. This repository contains the complete project architecture. The primary focus of this project is to implement stable physics mechanics, modular code design, and efficient game state management.

### 📂 File Navigation Guide (For Code Reviewers)
To review the C# source code directly in your browser without opening the Unity Editor, navigate to the following path:
👉 **Directory:** `Assets/Scripts/`

**Important Note on File Types:**
**Click on `.cs` files** (e.g., `Movement.cs`) to view the actual C# source code and logic.


### ⚙️ Technical Achievements & Core Mechanics
The following systems were built entirely from scratch using C#:

* **Physics & Kinematics (`Movement.cs`):** Engineered a responsive 2D character controller utilizing Rigidbody2D, optimizing velocity calculations for precise jumping and horizontal movement.
* **Collision & Hitbox Detection (`TrapCollision.cs`):** Implemented efficient trigger events (`OnTriggerEnter2D`) to detect environmental hazards and manage penalty mechanics without performance drops.
* **Data & Inventory Management (`PlayerInventory.cs` & `Key.cs`):** Created a scalable inventory logic to track collectible items and update the UI dynamically.
* **Dynamic Camera System (`Camera.cs`):** Programmed a customized camera follow algorithm using `LateUpdate` to ensure smooth visual tracking of the player character, avoiding physics stutters.
* **Game State & Flow (`Win.cs` & `Story.cs`):** Developed finite state logic to manage win/lose conditions and seamless scene transitions.

---

<a id="türkçe"></a>
## 🇹🇷 Türkçe

### 🎮 Proje Hakkında
"Payment for Freedom", Unity ve C# kullanılarak geliştirilmiş bir 2D platform oyunudur. Bu depo, projenin tam mimarisini barındırmaktadır. Projenin temel odak noktası; kararlı fizik mekanikleri oluşturmak, modüler kod tasarımı yapmak ve oyun durum yönetimini (game state) optimize etmektir.

### 📂 Dosya İnceleme Rehberi (Kod Okumaları İçin)
Unity editörünü açmaya gerek kalmadan, doğrudan tarayıcı üzerinden C# kaynak kodlarını okumak için şu dizine gidin:
👉 **Dizin:** `Assets/Scripts/`

**Dosya Uzantıları İçin Önemli Not:**
**`.cs` dosyalarına tıklayın** (Örn: `Movement.cs`). Yazılım algoritmaları ve mantıksal mimari bu dosyaların içindedir.
içermezler

### ⚙️ Teknik Başarılar ve Temel Mekanikler
Aşağıdaki sistemler C# kullanılarak sıfırdan geliştirilmiştir:

* **Fizik ve Kinematik (`Movement.cs`):** `Rigidbody2D` kullanılarak, hassas zıplama ve yatay hareket hesaplamaları için optimize edilmiş tepkisel bir 2D karakter kontrolcüsü yazıldı.
* **Çarpışma ve Hitbox Algılama (`TrapCollision.cs`):** Çevresel tehlikeleri algılamak ve performans kaybı yaşamadan ceza mekaniklerini tetiklemek için `OnTriggerEnter2D` olayları optimize edildi.
* **Veri ve Envanter Yönetimi (`PlayerInventory.cs` & `Key.cs`):** Toplanabilir öğeleri takip etmek ve arayüzü (UI) dinamik olarak güncellemek için ölçeklenebilir bir envanter mantığı oluşturuldu.
* **Dinamik Kamera Sistemi (`Camera.cs`):** Fiziksel hesaplamalarla çakışmayı önlemek adına `LateUpdate` fonksiyonu kullanılarak, karakteri pürüzsüz takip eden bir kamera algoritması programlandı.
* **Oyun Durumu ve Akışı (`Win.cs` & `Story.cs`):** Kazanma/kaybetme koşullarını ve sahne geçişlerini yönetmek için durum algoritmaları (state logic) kurgulandı.
