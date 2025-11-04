# 프로젝트 이름 Fire & Water (Dungeon)

## 📖 목차
1. [프로젝트 소개](#프로젝트-소개)
2. [주요기능](#주요기능)
3. [개발기간](#개발기간)
4. [기술스택](#기술스택)
5. [와이어프레임](#와이어프레임)
6. [프로젝트 파일 구조](#프로젝트-파일-구조)
7. [Trouble Shooting](#trouble-shooting)


## 👨‍🏫 프로젝트 소개
- 프로젝트 명 : Fire & Water (Dungeon)
- 프로젝트 설명 : '극' 내향인들끼리 모여서 만든 협력퍼즐 탐험게임
- 프로젝트 시작 계기 : Unity를 활용해서 3가지의 모티브 게임 중 하나를 선택해서 만들게 됨.
- 프로젝트 팀원
    - 팀장 : 엄성진
    - 팀원 : 안건우
    - 팀원 : 김동관
    - 팀원 : 유원영

## 💜 주요기능

- 기능 1
    - GameManager 에서 게임 실행의 전반적인 구동을 담당

- 기능 2
    - DataService 에서 플레이어의 클리어 정보 저장을 담당

- 기능 3
    - AchievementManager 에서 플레이어 클리어 정보를 데이터(업적)화 및 불러오기를 담당

- 기능 4
    - AudioManager 에서 게임의 BGM, SFX,  출력을 담당

- 기능 5
    - DataService 에서 플레이어의 클리어 정보 저장을 담당
    
- 기능 6
    - SceneTrasitionManager 에서 게임 스테이지 신의 전환을 담당        

- 기능 7
    - PlayerController 에서 Player 캐릭터의 선택을 담당

- 기능 8
    - BaseController 에서 Player 캐릭터의 움직임을 담당

- 기능 9
    - AnimationHandler 에서 Player 캐릭터의 애니메이션 출력을 담당

- 기능 10
    - PopupManager 에서 UI의 종류별로 출력을 담당

- 기능 11
    - InteractionObject 에서 필드 오브젝트들과의 상호작용을 담당


## ⏲️ 개발기간
- 총 8일   { 2025.10.29(수) ~ 2025.11.05(수) }


### 🖥️ Language
*  C#


### 🔧 Version Control
*  Git + GitHub


### 🧩 IDE
* Visual Studio


### 🧰 Framework
* net9.0


### 🚀 배포 (Deploy)
- **빌드 환경:** Unity 2022.3.62f2
- **배포 방식:** 
- **결과물:** 

## 와이어프레임


### 와이어프레임_초기

https://drive.google.com/file/d/1BGSdvtFrzQ0QccxZEe-LLJn0-wriQG4D/view


## 프로젝트 파일 구조

📦Assets
 ┣ 📂Animations
 ┃ ┣ 📂Obstacle
 ┃ ┃ ┣ 📜Bomb.controller
 ┃ ┃ ┣ 📜Bomb.controller.meta
 ┃ ┃ ┣ 📜BombAnimation.anim
 ┃ ┃ ┣ 📜BombAnimation.anim.meta
 ┃ ┃ ┣ 📜BombAnimation_explosion.anim
 ┃ ┃ ┣ 📜BombAnimation_explosion.anim.meta
 ┃ ┃ ┣ 📜FirePitfall.controller
 ┃ ┃ ┣ 📜FirePitfall.controller.meta
 ┃ ┃ ┣ 📜FirePitfallAnimation.anim
 ┃ ┃ ┣ 📜FirePitfallAnimation.anim.meta
 ┃ ┃ ┣ 📜FireWall.controller
 ┃ ┃ ┣ 📜FireWall.controller.meta
 ┃ ┃ ┣ 📜FireWallAnimation.anim
 ┃ ┃ ┣ 📜FireWallAnimation.anim.meta
 ┃ ┃ ┣ 📜IcePitfall.controller
 ┃ ┃ ┣ 📜IcePitfall.controller.meta
 ┃ ┃ ┣ 📜IcePitfallAnimation.anim
 ┃ ┃ ┣ 📜IcePitfallAnimation.anim.meta
 ┃ ┃ ┣ 📜IceWall.controller
 ┃ ┃ ┣ 📜IceWall.controller.meta
 ┃ ┃ ┣ 📜IceWallAnimation.anim
 ┃ ┃ ┗ 📜IceWallAnimation.anim.meta
 ┃ ┣ 📂Player
 ┃ ┃ ┣ 📂Player_Dwarf
 ┃ ┃ ┃ ┣ 📜Dead.anim
 ┃ ┃ ┃ ┣ 📜Dead.anim.meta
 ┃ ┃ ┃ ┣ 📜idle.anim
 ┃ ┃ ┃ ┣ 📜idle.anim.meta
 ┃ ┃ ┃ ┣ 📜Jump.anim
 ┃ ┃ ┃ ┣ 📜Jump.anim.meta
 ┃ ┃ ┃ ┣ 📜Move.anim
 ┃ ┃ ┃ ┣ 📜Move.anim.meta
 ┃ ┃ ┃ ┣ 📜Player_Dwarf_Fire.controller
 ┃ ┃ ┃ ┗ 📜Player_Dwarf_Fire.controller.meta
 ┃ ┃ ┣ 📂Player_Elf
 ┃ ┃ ┃ ┣ 📜DeadElf.anim
 ┃ ┃ ┃ ┣ 📜DeadElf.anim.meta
 ┃ ┃ ┃ ┣ 📜idle.anim
 ┃ ┃ ┃ ┣ 📜idle.anim.meta
 ┃ ┃ ┃ ┣ 📜Jump.anim
 ┃ ┃ ┃ ┣ 📜Jump.anim.meta
 ┃ ┃ ┃ ┣ 📜Move.anim
 ┃ ┃ ┃ ┣ 📜Move.anim.meta
 ┃ ┃ ┃ ┣ 📜Player_Elf_Water.controller
 ┃ ┃ ┃ ┗ 📜Player_Elf_Water.controller.meta
 ┃ ┃ ┣ 📂Player_Physics
 ┃ ┃ ┃ ┣ 📜NoFriction.physicsMaterial2D
 ┃ ┃ ┃ ┗ 📜NoFriction.physicsMaterial2D.meta
 ┃ ┃ ┣ 📂Player_Switch_Icon
 ┃ ┃ ┃ ┣ 📜Icon.anim
 ┃ ┃ ┃ ┣ 📜Icon.anim.meta
 ┃ ┃ ┃ ┣ 📜Switch_Icon.controller
 ┃ ┃ ┃ ┗ 📜Switch_Icon.controller.meta
 ┃ ┃ ┣ 📜Player_Dwarf.meta
 ┃ ┃ ┣ 📜Player_Elf.meta
 ┃ ┃ ┣ 📜Player_Physics.meta
 ┃ ┃ ┗ 📜Player_Switch_Icon.meta
 ┃ ┣ 📂Switch
 ┃ ┃ ┣ 📜Switch.controller
 ┃ ┃ ┣ 📜Switch.controller.meta
 ┃ ┃ ┣ 📜SwitchAnimation_L.anim
 ┃ ┃ ┣ 📜SwitchAnimation_L.anim.meta
 ┃ ┃ ┣ 📜SwitchAnimation_R.anim
 ┃ ┃ ┗ 📜SwitchAnimation_R.anim.meta
 ┃ ┣ 📜Obstacle.meta
 ┃ ┣ 📜Player.meta
 ┃ ┗ 📜Switch.meta
 ┣ 📂Editor
 ┃ ┣ 📜BootstrapSceneLoader.cs
 ┃ ┗ 📜BootstrapSceneLoader.cs.meta
 ┣ 📂Map_Pallete
 ┃ ┣ 📜New Palette.prefab
 ┃ ┗ 📜New Palette.prefab.meta
 ┣ 📂Prefabs
 ┃ ┣ 📂Interaction
 ┃ ┃ ┣ 📜Bombs.prefab
 ┃ ┃ ┣ 📜Bombs.prefab.meta
 ┃ ┃ ┣ 📜Grid_Elevator.prefab
 ┃ ┃ ┣ 📜Grid_Elevator.prefab.meta
 ┃ ┃ ┣ 📜Hole.prefab
 ┃ ┃ ┣ 📜Hole.prefab.meta
 ┃ ┃ ┣ 📜Map.prefab
 ┃ ┃ ┣ 📜Map.prefab.meta
 ┃ ┃ ┣ 📜Pitfall.prefab
 ┃ ┃ ┣ 📜Pitfall.prefab.meta
 ┃ ┃ ┣ 📜Switch.prefab
 ┃ ┃ ┣ 📜Switch.prefab.meta
 ┃ ┃ ┣ 📜Trap.prefab
 ┃ ┃ ┣ 📜Trap.prefab.meta
 ┃ ┃ ┣ 📜Wall.prefab
 ┃ ┃ ┗ 📜Wall.prefab.meta
 ┃ ┣ 📂Player
 ┃ ┃ ┣ 📜Player_Dwarf_Fire.prefab
 ┃ ┃ ┣ 📜Player_Dwarf_Fire.prefab.meta
 ┃ ┃ ┣ 📜Player_Elf_Water.prefab
 ┃ ┃ ┗ 📜Player_Elf_Water.prefab.meta
 ┃ ┣ 📂Trap
 ┃ ┃ ┣ 📜Arrow.prefab
 ┃ ┃ ┣ 📜Arrow.prefab.meta
 ┃ ┃ ┣ 📜Bow.prefab
 ┃ ┃ ┗ 📜Bow.prefab.meta
 ┃ ┣ 📂UI
 ┃ ┃ ┣ 📜AchievementSlot.prefab
 ┃ ┃ ┣ 📜AchievementSlot.prefab.meta
 ┃ ┃ ┣ 📜GameClear.prefab
 ┃ ┃ ┣ 📜GameClear.prefab.meta
 ┃ ┃ ┣ 📜GameClearManager.prefab
 ┃ ┃ ┣ 📜GameClearManager.prefab.meta
 ┃ ┃ ┣ 📜GameOver.prefab
 ┃ ┃ ┣ 📜GameOver.prefab.meta
 ┃ ┃ ┣ 📜GameOverManager.prefab
 ┃ ┃ ┣ 📜GameOverManager.prefab.meta
 ┃ ┃ ┣ 📜GameScene.prefab
 ┃ ┃ ┣ 📜GameScene.prefab.meta
 ┃ ┃ ┣ 📜PopupCanvas.prefab
 ┃ ┃ ┣ 📜PopupCanvas.prefab.meta
 ┃ ┃ ┣ 📜PopupManager.prefab
 ┃ ┃ ┣ 📜PopupManager.prefab.meta
 ┃ ┃ ┣ 📜StageInitializer.prefab
 ┃ ┃ ┣ 📜StageInitializer.prefab.meta
 ┃ ┃ ┣ 📜TimerText.prefab
 ┃ ┃ ┣ 📜TimerText.prefab.meta
 ┃ ┃ ┣ 📜Tutorial.prefab
 ┃ ┃ ┗ 📜Tutorial.prefab.meta
 ┃ ┣ 📜Interaction.meta
 ┃ ┣ 📜Player.meta
 ┃ ┣ 📜Trap.meta
 ┃ ┗ 📜UI.meta
 ┣ 📂Resources
 ┃ ┣ 📂AudioAsset
 ┃ ┃ ┣ 📂Player
 ┃ ┃ ┃ ┣ 📜jump.mp3
 ┃ ┃ ┃ ┣ 📜jump.mp3.meta
 ┃ ┃ ┃ ┣ 📜walk.mp3
 ┃ ┃ ┃ ┗ 📜walk.mp3.meta
 ┃ ┃ ┣ 📜change.mp3
 ┃ ┃ ┣ 📜change.mp3.meta
 ┃ ┃ ┣ 📜clear.mp3
 ┃ ┃ ┣ 📜clear.mp3.meta
 ┃ ┃ ┣ 📜click.mp3
 ┃ ┃ ┣ 📜click.mp3.meta
 ┃ ┃ ┣ 📜elevator.mp3
 ┃ ┃ ┣ 📜elevator.mp3.meta
 ┃ ┃ ┣ 📜entrance.mp3
 ┃ ┃ ┣ 📜entrance.mp3.meta
 ┃ ┃ ┣ 📜game.mp3
 ┃ ┃ ┣ 📜game.mp3.meta
 ┃ ┃ ┣ 📜gameOver.mp3
 ┃ ┃ ┣ 📜gameOver.mp3.meta
 ┃ ┃ ┣ 📜Player.meta
 ┃ ┃ ┣ 📜pop.mp3
 ┃ ┃ ┣ 📜pop.mp3.meta
 ┃ ┃ ┣ 📜switch.mp3
 ┃ ┃ ┣ 📜switch.mp3.meta
 ┃ ┃ ┣ 📜title.mp3
 ┃ ┃ ┗ 📜title.mp3.meta
 ┃ ┣ 📂ImageAsset
 ┃ ┃ ┣ 📂frames
 ┃ ┃ ┃ ┣ 📂Map
 ┃ ┃ ┃ ┃ ┣ 📜2211.w030.n003.491B.p1.491.jpg
 ┃ ┃ ┃ ┃ ┣ 📜2211.w030.n003.491B.p1.491.jpg.meta
 ┃ ┃ ┃ ┃ ┣ 📜AchivementBackGround.jpg
 ┃ ┃ ┃ ┃ ┣ 📜AchivementBackGround.jpg.meta
 ┃ ┃ ┃ ┃ ┣ 📜Stage2_Back.png
 ┃ ┃ ┃ ┃ ┣ 📜Stage2_Back.png.meta
 ┃ ┃ ┃ ┃ ┣ 📜Stage3_Back .png
 ┃ ┃ ┃ ┃ ┗ 📜Stage3_Back .png.meta
 ┃ ┃ ┃ ┣ 📜button_blue_down.png
 ┃ ┃ ┃ ┣ 📜button_blue_down.png.meta
 ┃ ┃ ┃ ┣ 📜button_blue_up.png
 ┃ ┃ ┃ ┣ 📜button_blue_up.png.meta
 ┃ ┃ ┃ ┣ 📜button_red_down.png
 ┃ ┃ ┃ ┣ 📜button_red_down.png.meta
 ┃ ┃ ┃ ┣ 📜button_red_up.png
 ┃ ┃ ┃ ┣ 📜button_red_up.png.meta
 ┃ ┃ ┃ ┣ 📜doors_leaf_closed.png
 ┃ ┃ ┃ ┣ 📜doors_leaf_closed.png.meta
 ┃ ┃ ┃ ┣ 📜doors_leaf_open.png
 ┃ ┃ ┃ ┣ 📜doors_leaf_open.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜dwarf_m_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_m_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜elf_m_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜elf_m_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜FireObastacle1.png
 ┃ ┃ ┃ ┣ 📜FireObastacle1.png.meta
 ┃ ┃ ┃ ┣ 📜FireObastacle2.png
 ┃ ┃ ┃ ┣ 📜FireObastacle2.png.meta
 ┃ ┃ ┃ ┣ 📜FireObastacle_Width1.png
 ┃ ┃ ┃ ┣ 📜FireObastacle_Width1.png.meta
 ┃ ┃ ┃ ┣ 📜FireObastacle_Width2.png
 ┃ ┃ ┃ ┣ 📜FireObastacle_Width2.png.meta
 ┃ ┃ ┃ ┣ 📜IceObastacle_Width1.png
 ┃ ┃ ┃ ┣ 📜IceObastacle_Width1.png.meta
 ┃ ┃ ┃ ┣ 📜IceObastacle_Width2.png
 ┃ ┃ ┃ ┣ 📜IceObastacle_Width2.png.meta
 ┃ ┃ ┃ ┣ 📜IceObstacle1.png
 ┃ ┃ ┃ ┣ 📜IceObstacle1.png.meta
 ┃ ┃ ┃ ┣ 📜IceObstacle2.png
 ┃ ┃ ┃ ┣ 📜IceObstacle2.png.meta
 ┃ ┃ ┃ ┣ 📜lever_left.png
 ┃ ┃ ┃ ┣ 📜lever_left.png.meta
 ┃ ┃ ┃ ┣ 📜lever_right.png
 ┃ ┃ ┃ ┣ 📜lever_right.png.meta
 ┃ ┃ ┃ ┣ 📜Map.meta
 ┃ ┃ ┃ ┣ 📜Player_Switch_Icon.png
 ┃ ┃ ┃ ┣ 📜Player_Switch_Icon.png.meta
 ┃ ┃ ┃ ┣ 📜pngwing.com.png
 ┃ ┃ ┃ ┣ 📜pngwing.com.png.meta
 ┃ ┃ ┃ ┣ 📜pngwing.com__1_-removebg-preview.png
 ┃ ┃ ┃ ┣ 📜pngwing.com__1_-removebg-preview.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_top_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_top_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_top_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_top_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_left.png
 ┃ ┃ ┃ ┣ 📜wall_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_right.png
 ┃ ┃ ┃ ┣ 📜wall_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_left.png
 ┃ ┃ ┃ ┣ 📜wall_top_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_mid.png
 ┃ ┃ ┃ ┣ 📜wall_top_mid.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_right.png
 ┃ ┃ ┃ ┣ 📜wall_top_right.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_bow_2.png
 ┃ ┃ ┃ ┣ 📜weapon_bow_2.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_knight_sword.png
 ┃ ┃ ┃ ┗ 📜weapon_knight_sword.png.meta
 ┃ ┃ ┣ 📂TitleImages
 ┃ ┃ ┃ ┣ 📜Title_NewImage.png
 ┃ ┃ ┃ ┗ 📜Title_NewImage.png.meta
 ┃ ┃ ┣ 📜.DS_Store
 ┃ ┃ ┣ 📜frames.meta
 ┃ ┃ ┣ 📜README
 ┃ ┃ ┣ 📜README.meta
 ┃ ┃ ┣ 📜tile_list_v1.7
 ┃ ┃ ┣ 📜tile_list_v1.7.meta
 ┃ ┃ ┗ 📜TitleImages.meta
 ┃ ┣ 📂ScriptableObjects
 ┃ ┃ ┣ 📂Achievements
 ┃ ┃ ┃ ┣ 📜Clear_Equal_1.asset
 ┃ ┃ ┃ ┣ 📜Clear_Equal_1.asset.meta
 ┃ ┃ ┃ ┣ 📜Clear_Equal_2.asset
 ┃ ┃ ┃ ┣ 📜Clear_Equal_2.asset.meta
 ┃ ┃ ┃ ┣ 📜Clear_Equal_3.asset
 ┃ ┃ ┃ ┣ 📜Clear_Equal_3.asset.meta
 ┃ ┃ ┃ ┣ 📜Death_ Equal_1.asset
 ┃ ┃ ┃ ┣ 📜Death_ Equal_1.asset.meta
 ┃ ┃ ┃ ┣ 📜Death_Equal_10.asset
 ┃ ┃ ┃ ┣ 📜Death_Equal_10.asset.meta
 ┃ ┃ ┃ ┣ 📜Death_Equal_2.asset
 ┃ ┃ ┃ ┣ 📜Death_Equal_2.asset.meta
 ┃ ┃ ┃ ┣ 📜Get_Rank_A.asset
 ┃ ┃ ┃ ┣ 📜Get_Rank_A.asset.meta
 ┃ ┃ ┃ ┣ 📜Get_Rank_B.asset
 ┃ ┃ ┃ ┣ 📜Get_Rank_B.asset.meta
 ┃ ┃ ┃ ┣ 📜Get_Rank_S.asset
 ┃ ┃ ┃ ┗ 📜Get_Rank_S.asset.meta
 ┃ ┃ ┗ 📜Achievements.meta
 ┃ ┣ 📜AudioAsset.meta
 ┃ ┣ 📜ImageAsset.meta
 ┃ ┗ 📜ScriptableObjects.meta
 ┣ 📂Scenes
 ┃ ┣ 📜AchievementScene.unity
 ┃ ┣ 📜AchievementScene.unity.meta
 ┃ ┣ 📜GamePlayScene_Stage1.unity
 ┃ ┣ 📜GamePlayScene_Stage1.unity.meta
 ┃ ┣ 📜GamePlayScene_Stage2.unity
 ┃ ┣ 📜GamePlayScene_Stage2.unity.meta
 ┃ ┣ 📜GamePlayScene_Stage3.unity
 ┃ ┣ 📜GamePlayScene_Stage3.unity.meta
 ┃ ┣ 📜Initialization.unity
 ┃ ┣ 📜Initialization.unity.meta
 ┃ ┣ 📜PopupScene.unity
 ┃ ┣ 📜PopupScene.unity.meta
 ┃ ┣ 📜TitleScene.unity
 ┃ ┗ 📜TitleScene.unity.meta
 ┣ 📂Scripts
 ┃ ┣ 📂Core
 ┃ ┃ ┣ 📜AchievementManager.cs
 ┃ ┃ ┣ 📜AchievementManager.cs.meta
 ┃ ┃ ┣ 📜AudioManager.cs
 ┃ ┃ ┣ 📜AudioManager.cs.meta
 ┃ ┃ ┣ 📜DataService.cs
 ┃ ┃ ┣ 📜DataService.cs.meta
 ┃ ┃ ┣ 📜GameManager.cs
 ┃ ┃ ┣ 📜GameManager.cs.meta
 ┃ ┃ ┣ 📜SceneTransitionManager.cs
 ┃ ┃ ┣ 📜SceneTransitionManager.cs.meta
 ┃ ┃ ┣ 📜SwitchingManager.cs
 ┃ ┃ ┗ 📜SwitchingManager.cs.meta
 ┃ ┣ 📂Data
 ┃ ┃ ┣ 📂ScriptableObjects
 ┃ ┃ ┃ ┣ 📜AchievementData.cs
 ┃ ┃ ┃ ┗ 📜AchievementData.cs.meta
 ┃ ┃ ┗ 📜ScriptableObjects.meta
 ┃ ┣ 📂Deprecated
 ┃ ┃ ┣ 📜Fire.cs
 ┃ ┃ ┣ 📜Fire.cs.meta
 ┃ ┃ ┣ 📜Player.cs
 ┃ ┃ ┣ 📜Player.cs.meta
 ┃ ┃ ┣ 📜Water.cs
 ┃ ┃ ┗ 📜Water.cs.meta
 ┃ ┣ 📂Features
 ┃ ┃ ┣ 📂Controller
 ┃ ┃ ┃ ┣ 📜AnimationHandler.cs
 ┃ ┃ ┃ ┣ 📜AnimationHandler.cs.meta
 ┃ ┃ ┃ ┣ 📜BaseController.cs
 ┃ ┃ ┃ ┣ 📜BaseController.cs.meta
 ┃ ┃ ┃ ┣ 📜PlayerController.cs
 ┃ ┃ ┃ ┗ 📜PlayerController.cs.meta
 ┃ ┃ ┣ 📂Entities
 ┃ ┃ ┃ ┣ 📂Interaction
 ┃ ┃ ┃ ┃ ┣ 📂Sample
 ┃ ┃ ┃ ┃ ┃ ┣ 📂Object
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜IElementObject.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜IElementObject.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜IReactiveObject.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜IReactiveObject.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜MovingElevator.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜MovingElevator.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Obstacle2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Obstacle2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜ReactiveObstacle2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜ReactiveObstacle2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜StaticObstacle2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜StaticObstacle2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Switch2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜Switch2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┣ 📂Player
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Player2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜Player2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┃ ┣ 📜PlayerController2.cs
 ┃ ┃ ┃ ┃ ┃ ┃ ┗ 📜PlayerController2.cs.meta
 ┃ ┃ ┃ ┃ ┃ ┣ 📜Object.meta
 ┃ ┃ ┃ ┃ ┃ ┗ 📜Player.meta
 ┃ ┃ ┃ ┃ ┣ 📜Arrow.cs
 ┃ ┃ ┃ ┃ ┣ 📜Arrow.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Bow.cs
 ┃ ┃ ┃ ┃ ┣ 📜Bow.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Door.cs
 ┃ ┃ ┃ ┃ ┣ 📜Door.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Elevator.cs
 ┃ ┃ ┃ ┃ ┣ 📜Elevator.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Hole.cs
 ┃ ┃ ┃ ┃ ┣ 📜Hole.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜InteractionObject.cs
 ┃ ┃ ┃ ┃ ┣ 📜InteractionObject.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Obstacle.cs
 ┃ ┃ ┃ ┃ ┣ 📜Obstacle.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Pitfall.cs
 ┃ ┃ ┃ ┃ ┣ 📜Pitfall.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Sample.meta
 ┃ ┃ ┃ ┃ ┣ 📜Switch.cs
 ┃ ┃ ┃ ┃ ┣ 📜Switch.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Trap.cs
 ┃ ┃ ┃ ┃ ┣ 📜Trap.cs.meta
 ┃ ┃ ┃ ┃ ┣ 📜Wall.cs
 ┃ ┃ ┃ ┃ ┗ 📜Wall.cs.meta
 ┃ ┃ ┃ ┣ 📜Achievement.cs
 ┃ ┃ ┃ ┣ 📜Achievement.cs.meta
 ┃ ┃ ┃ ┗ 📜Interaction.meta
 ┃ ┃ ┣ 📂Scene
 ┃ ┃ ┃ ┣ 📜AchievementScene.cs
 ┃ ┃ ┃ ┣ 📜AchievementScene.cs.meta
 ┃ ┃ ┃ ┣ 📜FollowBackground.cs
 ┃ ┃ ┃ ┣ 📜FollowBackground.cs.meta
 ┃ ┃ ┃ ┣ 📜GameScene.cs
 ┃ ┃ ┃ ┣ 📜GameScene.cs.meta
 ┃ ┃ ┃ ┣ 📜TitleScene.cs
 ┃ ┃ ┃ ┗ 📜TitleScene.cs.meta
 ┃ ┃ ┣ 📂UI
 ┃ ┃ ┃ ┣ 📜GameClearManager.cs
 ┃ ┃ ┃ ┣ 📜GameClearManager.cs.meta
 ┃ ┃ ┃ ┣ 📜GameOverManager.cs
 ┃ ┃ ┃ ┣ 📜GameOverManager.cs.meta
 ┃ ┃ ┃ ┣ 📜PopupManager.cs
 ┃ ┃ ┃ ┣ 📜PopupManager.cs.meta
 ┃ ┃ ┃ ┣ 📜StageInitializer.cs
 ┃ ┃ ┃ ┣ 📜StageInitializer.cs.meta
 ┃ ┃ ┃ ┣ 📜TimerUI.cs
 ┃ ┃ ┃ ┣ 📜TimerUI.cs.meta
 ┃ ┃ ┃ ┣ 📜TutorialPopup.cs
 ┃ ┃ ┃ ┗ 📜TutorialPopup.cs.meta
 ┃ ┃ ┣ 📜Controller.meta
 ┃ ┃ ┣ 📜Entities.meta
 ┃ ┃ ┣ 📜Scene.meta
 ┃ ┃ ┗ 📜UI.meta
 ┃ ┣ 📂Utils
 ┃ ┃ ┣ 📜Constants.cs
 ┃ ┃ ┣ 📜Constants.cs.meta
 ┃ ┃ ┣ 📜Enums.cs
 ┃ ┃ ┣ 📜Enums.cs.meta
 ┃ ┃ ┣ 📜JsonSerializer.cs
 ┃ ┃ ┣ 📜JsonSerializer.cs.meta
 ┃ ┃ ┣ 📜RuntimeInitializer.cs
 ┃ ┃ ┣ 📜RuntimeInitializer.cs.meta
 ┃ ┃ ┣ 📜SceneLoader.cs
 ┃ ┃ ┗ 📜SceneLoader.cs.meta
 ┃ ┣ 📜Core.meta
 ┃ ┣ 📜Data.meta
 ┃ ┣ 📜Deprecated.meta
 ┃ ┣ 📜Features.meta
 ┃ ┗ 📜Utils.meta
 ┣ 📂TextMesh Pro
 ┃ ┣ 📂Documentation
 ┃ ┃ ┣ 📜TextMesh Pro User Guide 2016.pdf
 ┃ ┃ ┗ 📜TextMesh Pro User Guide 2016.pdf.meta
 ┃ ┣ 📂Fonts
 ┃ ┃ ┣ 📜LiberationSans - OFL.txt
 ┃ ┃ ┣ 📜LiberationSans - OFL.txt.meta
 ┃ ┃ ┣ 📜LiberationSans.ttf
 ┃ ┃ ┗ 📜LiberationSans.ttf.meta
 ┃ ┣ 📂Resources
 ┃ ┃ ┣ 📂Fonts & Materials
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Drop Shadow.mat
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Drop Shadow.mat.meta
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Fallback.asset
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Fallback.asset.meta
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Outline.mat
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF - Outline.mat.meta
 ┃ ┃ ┃ ┣ 📜LiberationSans SDF.asset
 ┃ ┃ ┃ ┗ 📜LiberationSans SDF.asset.meta
 ┃ ┃ ┣ 📂Sprite Assets
 ┃ ┃ ┃ ┣ 📜EmojiOne.asset
 ┃ ┃ ┃ ┗ 📜EmojiOne.asset.meta
 ┃ ┃ ┣ 📂Style Sheets
 ┃ ┃ ┃ ┣ 📜Default Style Sheet.asset
 ┃ ┃ ┃ ┗ 📜Default Style Sheet.asset.meta
 ┃ ┃ ┣ 📜Fonts & Materials.meta
 ┃ ┃ ┣ 📜LineBreaking Following Characters.txt
 ┃ ┃ ┣ 📜LineBreaking Following Characters.txt.meta
 ┃ ┃ ┣ 📜LineBreaking Leading Characters.txt
 ┃ ┃ ┣ 📜LineBreaking Leading Characters.txt.meta
 ┃ ┃ ┣ 📜Sprite Assets.meta
 ┃ ┃ ┣ 📜Style Sheets.meta
 ┃ ┃ ┣ 📜TMP Settings.asset
 ┃ ┃ ┗ 📜TMP Settings.asset.meta
 ┃ ┣ 📂Shaders
 ┃ ┃ ┣ 📜TMPro.cginc
 ┃ ┃ ┣ 📜TMPro.cginc.meta
 ┃ ┃ ┣ 📜TMPro_Mobile.cginc
 ┃ ┃ ┣ 📜TMPro_Mobile.cginc.meta
 ┃ ┃ ┣ 📜TMPro_Properties.cginc
 ┃ ┃ ┣ 📜TMPro_Properties.cginc.meta
 ┃ ┃ ┣ 📜TMPro_Surface.cginc
 ┃ ┃ ┣ 📜TMPro_Surface.cginc.meta
 ┃ ┃ ┣ 📜TMP_Bitmap-Custom-Atlas.shader
 ┃ ┃ ┣ 📜TMP_Bitmap-Custom-Atlas.shader.meta
 ┃ ┃ ┣ 📜TMP_Bitmap-Mobile.shader
 ┃ ┃ ┣ 📜TMP_Bitmap-Mobile.shader.meta
 ┃ ┃ ┣ 📜TMP_Bitmap.shader
 ┃ ┃ ┣ 📜TMP_Bitmap.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF Overlay.shader
 ┃ ┃ ┣ 📜TMP_SDF Overlay.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF SSD.shader
 ┃ ┃ ┣ 📜TMP_SDF SSD.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Mobile Masking.shader
 ┃ ┃ ┣ 📜TMP_SDF-Mobile Masking.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Mobile Overlay.shader
 ┃ ┃ ┣ 📜TMP_SDF-Mobile Overlay.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Mobile SSD.shader
 ┃ ┃ ┣ 📜TMP_SDF-Mobile SSD.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Mobile.shader
 ┃ ┃ ┣ 📜TMP_SDF-Mobile.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Surface-Mobile.shader
 ┃ ┃ ┣ 📜TMP_SDF-Surface-Mobile.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF-Surface.shader
 ┃ ┃ ┣ 📜TMP_SDF-Surface.shader.meta
 ┃ ┃ ┣ 📜TMP_SDF.shader
 ┃ ┃ ┣ 📜TMP_SDF.shader.meta
 ┃ ┃ ┣ 📜TMP_Sprite.shader
 ┃ ┃ ┗ 📜TMP_Sprite.shader.meta
 ┃ ┣ 📂Sprites
 ┃ ┃ ┣ 📜EmojiOne Attribution.txt
 ┃ ┃ ┣ 📜EmojiOne Attribution.txt.meta
 ┃ ┃ ┣ 📜EmojiOne.json
 ┃ ┃ ┣ 📜EmojiOne.json.meta
 ┃ ┃ ┣ 📜EmojiOne.png
 ┃ ┃ ┗ 📜EmojiOne.png.meta
 ┃ ┣ 📜Documentation.meta
 ┃ ┣ 📜Fonts.meta
 ┃ ┣ 📜Resources.meta
 ┃ ┣ 📜Shaders.meta
 ┃ ┗ 📜Sprites.meta
 ┣ 📂Tiles
 ┃ ┣ 📜Door.asset
 ┃ ┣ 📜Door.asset.meta
 ┃ ┣ 📜Elevator.asset
 ┃ ┣ 📜Elevator.asset.meta
 ┃ ┣ 📜Fire Obstacle.asset
 ┃ ┣ 📜Fire Obstacle.asset.meta
 ┃ ┣ 📜FireButton.asset
 ┃ ┣ 📜FireButton.asset.meta
 ┃ ┣ 📜Floor.asset
 ┃ ┣ 📜Floor.asset.meta
 ┃ ┣ 📜Ground.asset
 ┃ ┣ 📜Ground.asset.meta
 ┃ ┣ 📜Ice Obastacle.asset
 ┃ ┣ 📜Ice Obastacle.asset.meta
 ┃ ┣ 📜IceButton.asset
 ┃ ┣ 📜IceButton.asset.meta
 ┃ ┣ 📜Switch.asset
 ┃ ┗ 📜Switch.asset.meta
 ┣ 📜Animations.meta
 ┣ 📜Editor.meta
 ┣ 📜Map_Pallete.meta
 ┣ 📜Prefabs.meta
 ┣ 📜Resources.meta
 ┣ 📜Scenes.meta
 ┣ 📜Scripts.meta
 ┣ 📜TextMesh Pro.meta
 ┗ 📜Tiles.meta

 ## Trouble Shooting

 