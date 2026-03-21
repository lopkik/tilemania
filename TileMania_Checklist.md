# ✅ TileMania — Student Progress Checklist

## CS 4700: Game Design Studio | Unity 6 + C#

**Name:** **\*\***\*\***\*\***\_\_\_**\*\***\*\***\*\***  
**Date Started:** \***\*\*\*\*\***\_\_\_\***\*\*\*\*\***  
**Date Submitted:** \***\*\*\*\*\***\_\***\*\*\*\*\***

---

## How to Use This Checklist

- Check each box **as you complete it** — don't pre-check!
- Use the ⚠️ column to mark things you're stuck on and need help with
- Review the **Reflection Questions** at the end before submitting

---

## 📁 Section 1 — Project Setup

| ✅ Done | ⚠️ Stuck | Task                                                                |
| :-----: | :------: | ------------------------------------------------------------------- |
|    x    |    ☐     | Created Unity 6 project with **2D URP** template                    |
|    x    |    ☐     | Installed **Cinemachine** package                                   |
|    x    |    ☐     | Installed **2D Tilemap Extras** (for Rule Tiles)                    |
|    x    |    ☐     | Created folder structure: Art/, Scripts/, Prefabs/, Audio/, Scenes/ |
|    x    |    ☐     | Imported or created placeholder sprites                             |
|    x    |    ☐     | Configured sprites: Filter Mode = Point, PPU = 16                   |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🗺️ Section 2 — Tilemap World Building

| ✅ Done | ⚠️ Stuck | Task                                                                          |
| :-----: | :------: | ----------------------------------------------------------------------------- |
|    x    |    ☐     | Created `Grid` with at least 3 Tilemap children (Ground, Hazards, Background) |
|    x    |    ☐     | Created a **Rule Tile** for the ground                                        |
|    x    |    ☐     | Added at least 5 rules to the Rule Tile (edges, corners, center)              |
|    x    |    ☐     | Painted a level with platforms, gaps, and elevation changes                   |
|    x    |    ☐     | Added **Tilemap Collider 2D** to Ground                                       |
|    x    |    ☐     | Added **Composite Collider 2D** and enabled "Used By Composite"               |
|    x    |    ☐     | Hazard Tilemap has collider with **Is Trigger: true**                         |
|    x    |    ☐     | Background Tilemap has Order in Layer = -1                                    |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🏃 Section 3 — Player Movement & Physics

| ✅ Done | ⚠️ Stuck | Task                                                                    |
| :-----: | :------: | ----------------------------------------------------------------------- |
|    x    |    ☐     | Player has: SpriteRenderer, Rigidbody2D, CapsuleCollider2D, Animator    |
|    x    |    ☐     | Rigidbody2D: Collision Detection = Continuous, Freeze Rotation Z = true |
|    x    |    ☐     | `PlayerMovement.cs` attached and compiles without errors                |
|    x    |    ☐     | `GroundCheck` child object created at bottom of player                  |
|    x    |    ☐     | Player moves left/right with A/D or arrow keys                          |
|    x    |    ☐     | Player jumps with Space and only when grounded                          |
|    x    |    ☐     | Sprite flips direction when moving                                      |
|    x    |    ☐     | Better jump physics applied (fall feels snappy, tap = short jump)       |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🎬 Section 4 — Player Animation

| ✅ Done | ⚠️ Stuck | Task                                                                   |
| :-----: | :------: | ---------------------------------------------------------------------- |
|    x    |    ☐     | `Player_Idle` animation clip created                                   |
|    x    |    ☐     | `Player_Run` animation clip created                                    |
|    x    |    ☐     | `Player_Jump` animation clip created                                   |
|    x    |    ☐     | `Player_Fall` animation clip created                                   |
|    x    |    ☐     | `Player_Death` animation clip created                                  |
|    x    |    ☐     | Animator parameters set: `isRunning`, `isGrounded`, `yVelocity`, `die` |
|    x    |    ☐     | All transitions wired correctly (no floating states)                   |
|    x    |    ☐     | "Has Exit Time" unchecked on all movement transitions                  |
|    x    |    ☐     | Animations play correctly in Play Mode                                 |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 📷 Section 5 — Camera

| ✅ Done | ⚠️ Stuck | Task                                                    |
| :-----: | :------: | ------------------------------------------------------- |
|    x    |    ☐     | Cinemachine Virtual Camera added to scene               |
|    x    |    ☐     | Camera follows player smoothly                          |
|    x    |    ☐     | Camera confined to level bounds (CinemachineConfiner2D) |
|    x    |    ☐     | Camera shake implemented in `CameraShake.cs`            |
|    ☐    |    ☐     | Camera shakes when player takes damage                  |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🔲 Section 6 — Layers & Collision Matrix

| ✅ Done | ⚠️ Stuck | Task                                                                             |
| :-----: | :------: | -------------------------------------------------------------------------------- |
|    x    |    ☐     | Created layers: Ground, Player, Enemy, Hazard, PlayerProjectile, EnemyProjectile |
|    x    |    ☐     | Ground Tilemap assigned to Ground layer                                          |
|    x    |    ☐     | Player assigned to Player layer                                                  |
|    x    |    ☐     | Layer Collision Matrix configured (PlayerProjectile ✗ Player, Enemy ✗ Enemy)     |
|    x    |    ☐     | PlayerMovement Ground Check uses correct layer mask                              |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 👾 Section 7 — Enemy AI

| ✅ Done | ⚠️ Stuck | Task                                                               |
| :-----: | :------: | ------------------------------------------------------------------ |
|    x    |    ☐     | Enemy prefab created with Rigidbody2D, CapsuleCollider2D, Animator |
|    x    |    ☐     | Enemy assigned to Enemy layer                                      |
|    x    |    ☐     | `EnemyPatrol.cs` attached, enemy moves left and right              |
|    x    |    ☐     | Enemy turns at waypoint boundaries                                 |
|    x    |    ☐     | Enemy turns at ledges (no ground detected)                         |
|    x    |    ☐     | Enemy sprite flips direction correctly                             |
|    x    |    ☐     | `EnemyHurt.cs` — touching enemy damages player                     |
|    x    |    ☐     | Enemy `Die()` plays animation and removes GameObject               |
|    x    |    ☐     | At least **2 enemies** placed in the level                         |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🏹 Section 8 — Shooting System

| ✅ Done | ⚠️ Stuck | Task                                                                       |
| :-----: | :------: | -------------------------------------------------------------------------- |
|    x    |    ☐     | Arrow prefab created with Rigidbody2D (gravity 0), BoxCollider2D (trigger) |
|    x    |    ☐     | Arrow assigned to PlayerProjectile layer                                   |
|    x    |    ☐     | `Arrow.cs` moves in correct direction                                      |
|    x    |    ☐     | Arrow destroys on hitting an enemy                                         |
|    x    |    ☐     | Arrow destroys on hitting ground                                           |
|    x    |    ☐     | Arrow has max lifetime (auto-destroys after 3s)                            |
|    x    |    ☐     | `PlayerShooter.cs` fires on left-click (Fire1)                             |
|    x    |    ☐     | Fire rate limit prevents spam                                              |
|    x    |    ☐     | Arrows fire in the direction the player faces                              |
|    x    |    ☐     | `FirePoint` child object positioned correctly                              |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## ❤️ Section 9 — Health & Damage

| ✅ Done | ⚠️ Stuck | Task                                                            |
| :-----: | :------: | --------------------------------------------------------------- |
|    x    |    ☐     | `PlayerHealth.cs` tracks current / max health                   |
|    x    |    ☐     | UI hearts update when player takes damage                       |
|    x    |    ☐     | Invincibility frames work after taking damage (flashing effect) |
|    x    |    ☐     | Player death triggers game over flow                            |
|    x    |    ☐     | `GameSession.cs` singleton persists across scenes               |
|    x    |    ☐     | Lives system: death decrements lives, reloads scene             |
|    x    |    ☐     | Out of lives → loads Game Over scene                            |
|    x    |    ☐     | Hazard tiles damage/kill player on touch                        |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🎬 Section 10 — Scenes & Game States

| ✅ Done | ⚠️ Stuck | Task                                           |
| :-----: | :------: | ---------------------------------------------- |
|    x    |    ☐     | Build Settings has all scenes in correct order |
|    x    |    ☐     | Main Menu scene with Start button works        |
|    x    |    ☐     | Game Over scene exists and loads correctly     |
|    x    |    ☐     | Level Exit triggers next level load            |
|    x    |    ☐     | Win scene or win condition implemented         |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🎵 Section 11 — Audio & Polish

| ✅ Done | ⚠️ Stuck | Task                                                   |
| :-----: | :------: | ------------------------------------------------------ |
|    x    |    ☐     | Background music loops on AudioSource                  |
|    x    |    ☐     | Jump SFX plays when player jumps                       |
|    x    |    ☐     | Shoot SFX plays when player fires                      |
|    x    |    ☐     | Damage SFX plays when player is hit                    |
|    x    |    ☐     | At least 1 particle effect (death, hit, collect, etc.) |

**Section Notes:** ****\*\*****\*\*****\*\*****\_\_\_****\*\*****\*\*****\*\*****

---

## 🎨 Quality Standards

### Technical Quality

| ✅  | Standard                                                       |
| :-: | -------------------------------------------------------------- |
|  x  | No null reference errors in Console during normal play         |
|  x  | All scripts organized in correct subfolders                    |
|  x  | All tweakable values use `[SerializeField]` — no magic numbers |
|  x  | Enemies are **prefabs** (not unique scene objects)             |
|  x  | Arrow is a **prefab**                                          |
|  x  | GameObjects are named clearly in Hierarchy                     |
|  x  | Unused GameObjects/scripts removed                             |

### Design Quality

| ✅  | Standard                                                   |
| :-: | ---------------------------------------------------------- |
|  x  | Level has a clear start and end                            |
|  x  | Level has varied terrain (high platforms, low areas, gaps) |
|  x  | Difficulty ramps up through the level                      |
|  x  | Player can distinguish hazards from safe ground visually   |
|  x  | Game is playable start to finish without bugs              |

---

## 🚀 Extension Features (Optional — Choose 1+)

| ✅  | Difficulty | Feature                                              |
| :-: | :--------: | ---------------------------------------------------- |
|  x  |     🟢     | Double jump                                          |
|  ☐  |     🟢     | Animated collectible coins/gems                      |
|  ☐  |     🟢     | Multiple enemy types (reskins with different speeds) |
|  ☐  |     🟡     | Checkpoint system                                    |
|  ☐  |     🟡     | Moving platform                                      |
|  ☐  |     🟡     | Enemy with ranged attack                             |
|  ☐  |     🟡     | Score system with on-screen display                  |
|  ☐  |     🔴     | Boss enemy with health bar                           |
|  ☐  |     🔴     | Multiple levels (3+) with scene transitions          |
|  ☐  |     🔴     | Save system (high score persists between sessions)   |

**Extension chosen:** **\*\*\*\***\*\***\*\*\*\***\_\_\_**\*\*\*\***\*\***\*\*\*\***  
**Brief description of what you added:** **\*\*\*\***\*\***\*\*\*\***\_\_\_**\*\*\*\***\*\***\*\*\*\***

---

## 📤 Submission Checklist

| ✅  | Task                                                                                           |
| :-: | ---------------------------------------------------------------------------------------------- |
|  ☐  | Project builds without errors (File → Build Settings → Build And Run)                          |
|  ☐  | Game is playable from Main Menu to Game Over/Win                                               |
|  ☐  | Submitted GitHub repository link on Canvas                                                     |
|  ☐  | Repository is **public** or instructor has been given access                                   |
|  ☐  | All 3 tutorial documents included in repo (`Tutorial.md`, `Checklist.md`, `QuickReference.md`) |
|  ☐  | Completed **Reflection Questions** (below)                                                     |

---

## 🪞 Reflection Questions

Answer these in **2–4 sentences each**. These are the same questions you'll revisit across all four projects — track how your thinking evolves!

**1. What was your rapid prototype goal for this project?**

---

---

**2. How closely did your final game match your original prototype vision? What changed and why?**

---

---

**3. What is the most technically challenging thing you implemented? How did you solve it?**

---

---

**4. If you had one more week, what would you add or change?**

---

---

**5. How does your approach to game development now compare to when you started the course?**

---

---

---

## 🆘 Stuck? Try These Steps

**Before asking for help:**

1. ☐ Read the **error message** in Console carefully — it tells you the file and line number
2. ☐ Check the **Inspector** — is every serialized field assigned?
3. ☐ Check **Tags and Layers** — are layers set correctly?
4. ☐ Checked the **Layer Collision Matrix**?
5. ☐ Searched the error message in the Unity Docs or Discord?
6. ☐ Tried rubber-duck debugging (explain the code out loud line by line)?

**If still stuck:** Post in Discord with:

- Screenshot of the **Console error**
- Screenshot of the **Inspector** for the relevant GameObject
- The **script** causing the issue

---

_TileMania Checklist | CS 4700: Game Design Studio | Unity 6 + C#_
