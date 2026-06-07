>  🇬🇧 English *As bugs are identified, they will be fixed, and the project will be continuously improved.*

>  🇹🇷 Türkçe *Proje hataları fark edildikçe düzeltilecek ve proje sürekli olarak daha iyi hale getirilecektir.*

# Payment for Freedom - Unity 2D Platformer

**Language:** [English](#english) | [Türkçe](#türkçe)

---

<a id="english"></a>
## 🇬🇧 English

### 🎮 About the Project
"Payment for Freedom" is a 2D platformer game developed using Unity and C#. This repository contains the complete project architecture. The primary focus of this project is to implement stable physics mechanics, modular code design, and efficient game state management.

**Important Note on File Types:**
**Click on `.cs` files** (e.g., `Movement.cs`). The software algorithms are inside these files. You cannot review the code through `.meta` extension files.

### 📂 File Navigation Guide (For Code Reviewers)
To review the C# source code directly in your browser without opening the Unity Editor, navigate to the following path:

👉 `PaymentforFreedom/Final Project/Assets/Scripts/`

### ⚙️ Technical Achievements & Core Mechanics
The following systems were built entirely from scratch using C#:

* **Physics & Kinematics (`Movement.cs`):** A 2D character controller was written using `Rigidbody2D` for jumping and horizontal movement.
* **Collision & Hitbox Detection (`TrapCollision.cs`):** `OnTriggerEnter2D` events were used in Unity to trigger penalty mechanics.
* **Data & Inventory Management (`PlayerInventory.cs` & `Key.cs`):** An inventory logic was created to track collectible items and update the UI dynamically.
* **Dynamic Camera System (`Camera.cs`):** A camera algorithm was programmed to follow the character.
* **Game State & Flow (`Win.cs` & `Story.cs`):** State logic was set up to manage win/lose conditions and scene transitions.

---

<a id="türkçe"></a>
## 🇹🇷 Türkçe

### 🎮 Proje Hakkında
"Payment for Freedom", Unity ve C# kullanılarak geliştirilmiş bir 2D platform oyunudur. Bu depo, projenin tam mimarisini barındırmaktadır. Projenin temel odak noktası; kararlı fizik mekanikleri oluşturmak, modüler kod tasarımı yapmak ve oyun durum yönetimini (game state) optimize etmektir.

**Dosya Uzantıları İçin Önemli Not:**
**`.cs` dosyalarına tıklayın** (Örn: `Movement.cs`). Yazılım algoritmaları bu dosyaların içindedir.
`.meta` uzantılı dosyalar üzerinden kodları inceleyemezsiniz.

### 📂 Dosya İnceleme Rehberi (Kod Okumaları İçin)
Unity editörünü açmaya gerek kalmadan, doğrudan tarayıcı üzerinden C# kaynak kodlarını okumak için şu dizine gidin:

👉 `PaymentforFreedom/Final Project/Assets/Scripts/`

### ⚙️ Teknik Başarılar ve Temel Mekanikler
Aşağıdaki sistemler C# kullanılarak sıfırdan geliştirilmiştir:

* **Fizik ve Kinematik (`Movement.cs`):** `Rigidbody2D` kullanılarak, zıplama ve yatay hareket için bir 2D karakter kontrolcüsü yazıldı.
* **Çarpışma ve Hitbox Algılama (`TrapCollision.cs`):** Ceza mekaniklerini tetiklemek için Unity üzerinden `OnTriggerEnter2D` olayları yapıldı.
* **Veri ve Envanter Yönetimi (`PlayerInventory.cs` & `Key.cs`):** Toplanabilir öğeleri takip etmek ve arayüzü (UI) dinamik olarak güncellemek için bir envanter mantığı oluşturuldu.
* **Dinamik Kamera Sistemi (`Camera.cs`):** Karakteri takip eden bir kamera algoritması programlandı.
* **Oyun Durumu ve Akışı (`Win.cs` & `Story.cs`):** Kazanma/kaybetme koşullarını ve sahne geçişlerini yönetmek için durum algoritmaları (state logic) kurgulandı.
