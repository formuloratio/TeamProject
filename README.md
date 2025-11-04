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
 ┣ 📂0x72_DungeonTilesetII_v1.7
 ┃ ┣ 📂0x72_DungeonTilesetII_v1.7
 ┃ ┃ ┣ 📂frames
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜angel_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜angel_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜big_demon_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜big_demon_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜big_zombie_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜big_zombie_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜bomb_f0.png
 ┃ ┃ ┃ ┣ 📜bomb_f0.png.meta
 ┃ ┃ ┃ ┣ 📜bomb_f1.png
 ┃ ┃ ┃ ┣ 📜bomb_f1.png.meta
 ┃ ┃ ┃ ┣ 📜bomb_f2.png
 ┃ ┃ ┃ ┣ 📜bomb_f2.png.meta
 ┃ ┃ ┃ ┣ 📜button_blue_down.png
 ┃ ┃ ┃ ┣ 📜button_blue_down.png.meta
 ┃ ┃ ┃ ┣ 📜button_blue_up.png
 ┃ ┃ ┃ ┣ 📜button_blue_up.png.meta
 ┃ ┃ ┃ ┣ 📜button_red_down.png
 ┃ ┃ ┃ ┣ 📜button_red_down.png.meta
 ┃ ┃ ┃ ┣ 📜button_red_up.png
 ┃ ┃ ┃ ┣ 📜button_red_up.png.meta
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f0.png
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f1.png
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f2.png
 ┃ ┃ ┃ ┣ 📜chest_empty_open_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f0.png
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f1.png
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f2.png
 ┃ ┃ ┃ ┣ 📜chest_full_open_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f0.png
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f1.png
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f2.png
 ┃ ┃ ┃ ┣ 📜chest_mimic_open_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜chort_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜chort_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜coin_anim_f0.png
 ┃ ┃ ┃ ┣ 📜coin_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜coin_anim_f1.png
 ┃ ┃ ┃ ┣ 📜coin_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜coin_anim_f2.png
 ┃ ┃ ┃ ┣ 📜coin_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜coin_anim_f3.png
 ┃ ┃ ┃ ┣ 📜coin_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜column.png
 ┃ ┃ ┃ ┣ 📜column.png.meta
 ┃ ┃ ┃ ┣ 📜column_wall.png
 ┃ ┃ ┃ ┣ 📜column_wall.png.meta
 ┃ ┃ ┃ ┣ 📜crate.png
 ┃ ┃ ┃ ┣ 📜crate.png.meta
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜doc_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜doc_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜doors_frame_left.png
 ┃ ┃ ┃ ┣ 📜doors_frame_left.png.meta
 ┃ ┃ ┃ ┣ 📜doors_frame_right.png
 ┃ ┃ ┃ ┣ 📜doors_frame_right.png.meta
 ┃ ┃ ┃ ┣ 📜doors_frame_top.png
 ┃ ┃ ┃ ┣ 📜doors_frame_top.png.meta
 ┃ ┃ ┃ ┣ 📜doors_leaf_closed.png
 ┃ ┃ ┃ ┣ 📜doors_leaf_closed.png.meta
 ┃ ┃ ┃ ┣ 📜doors_leaf_open.png
 ┃ ┃ ┃ ┣ 📜doors_leaf_open.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜dwarf_f_run_anim_f3.png.meta
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
 ┃ ┃ ┃ ┣ 📜edge_down.png
 ┃ ┃ ┃ ┣ 📜edge_down.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_f_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜elf_f_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜elf_f_run_anim_f3.png.meta
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
 ┃ ┃ ┃ ┣ 📜flask_big_blue.png
 ┃ ┃ ┃ ┣ 📜flask_big_blue.png.meta
 ┃ ┃ ┃ ┣ 📜flask_big_green.png
 ┃ ┃ ┃ ┣ 📜flask_big_green.png.meta
 ┃ ┃ ┃ ┣ 📜flask_big_red.png
 ┃ ┃ ┃ ┣ 📜flask_big_red.png.meta
 ┃ ┃ ┃ ┣ 📜flask_big_yellow.png
 ┃ ┃ ┃ ┣ 📜flask_big_yellow.png.meta
 ┃ ┃ ┃ ┣ 📜flask_blue.png
 ┃ ┃ ┃ ┣ 📜flask_blue.png.meta
 ┃ ┃ ┃ ┣ 📜flask_green.png
 ┃ ┃ ┃ ┣ 📜flask_green.png.meta
 ┃ ┃ ┃ ┣ 📜flask_red.png
 ┃ ┃ ┃ ┣ 📜flask_red.png.meta
 ┃ ┃ ┃ ┣ 📜flask_yellow.png
 ┃ ┃ ┃ ┣ 📜flask_yellow.png.meta
 ┃ ┃ ┃ ┣ 📜floor_1.png
 ┃ ┃ ┃ ┣ 📜floor_1.png.meta
 ┃ ┃ ┃ ┣ 📜floor_2.png
 ┃ ┃ ┃ ┣ 📜floor_2.png.meta
 ┃ ┃ ┃ ┣ 📜floor_3.png
 ┃ ┃ ┃ ┣ 📜floor_3.png.meta
 ┃ ┃ ┃ ┣ 📜floor_4.png
 ┃ ┃ ┃ ┣ 📜floor_4.png.meta
 ┃ ┃ ┃ ┣ 📜floor_5.png
 ┃ ┃ ┃ ┣ 📜floor_5.png.meta
 ┃ ┃ ┃ ┣ 📜floor_6.png
 ┃ ┃ ┃ ┣ 📜floor_6.png.meta
 ┃ ┃ ┃ ┣ 📜floor_7.png
 ┃ ┃ ┃ ┣ 📜floor_7.png.meta
 ┃ ┃ ┃ ┣ 📜floor_8.png
 ┃ ┃ ┃ ┣ 📜floor_8.png.meta
 ┃ ┃ ┃ ┣ 📜floor_ladder.png
 ┃ ┃ ┃ ┣ 📜floor_ladder.png.meta
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f0.png
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f1.png
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f2.png
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f3.png
 ┃ ┃ ┃ ┣ 📜floor_spikes_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜floor_stairs.png
 ┃ ┃ ┃ ┣ 📜floor_stairs.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜goblin_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜goblin_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜hole.png
 ┃ ┃ ┃ ┣ 📜hole.png.meta
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f0.png
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f1.png
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f2.png
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f3.png
 ┃ ┃ ┃ ┣ 📜ice_zombie_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜imp_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜imp_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_f_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜knight_f_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜knight_f_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_m_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜knight_m_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜knight_m_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜lever_left.png
 ┃ ┃ ┃ ┣ 📜lever_left.png.meta
 ┃ ┃ ┃ ┣ 📜lever_right.png
 ┃ ┃ ┃ ┣ 📜lever_right.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_f_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜lizard_f_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜lizard_f_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_m_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜lizard_m_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜lizard_m_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜masked_orc_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜masked_orc_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜muddy_anim_f0.png
 ┃ ┃ ┃ ┣ 📜muddy_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜muddy_anim_f1.png
 ┃ ┃ ┃ ┣ 📜muddy_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜muddy_anim_f2.png
 ┃ ┃ ┃ ┣ 📜muddy_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜muddy_anim_f3.png
 ┃ ┃ ┃ ┣ 📜muddy_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f0.png
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f1.png
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f2.png
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f3.png
 ┃ ┃ ┃ ┣ 📜necromancer_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜ogre_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜ogre_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜orc_shaman_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜orc_warrior_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜pumpkin_dude_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜skelet_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜skelet_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜skull.png
 ┃ ┃ ┃ ┣ 📜skull.png.meta
 ┃ ┃ ┃ ┣ 📜slug_anim_f0.png
 ┃ ┃ ┃ ┣ 📜slug_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜slug_anim_f1.png
 ┃ ┃ ┃ ┣ 📜slug_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜slug_anim_f2.png
 ┃ ┃ ┃ ┣ 📜slug_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜slug_anim_f3.png
 ┃ ┃ ┃ ┣ 📜slug_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜swampy_anim_f0.png
 ┃ ┃ ┃ ┣ 📜swampy_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜swampy_anim_f1.png
 ┃ ┃ ┃ ┣ 📜swampy_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜swampy_anim_f2.png
 ┃ ┃ ┃ ┣ 📜swampy_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜swampy_anim_f3.png
 ┃ ┃ ┃ ┣ 📜swampy_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f0.png
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f1.png
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f2.png
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f3.png
 ┃ ┃ ┃ ┣ 📜tiny_slug_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜tiny_zombie_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜ui_heart_empty.png
 ┃ ┃ ┃ ┣ 📜ui_heart_empty.png.meta
 ┃ ┃ ┃ ┣ 📜ui_heart_full.png
 ┃ ┃ ┃ ┣ 📜ui_heart_full.png.meta
 ┃ ┃ ┃ ┣ 📜ui_heart_half.png
 ┃ ┃ ┃ ┣ 📜ui_heart_half.png.meta
 ┃ ┃ ┃ ┣ 📜wall_banner_blue.png
 ┃ ┃ ┃ ┣ 📜wall_banner_blue.png.meta
 ┃ ┃ ┃ ┣ 📜wall_banner_green.png
 ┃ ┃ ┃ ┣ 📜wall_banner_green.png.meta
 ┃ ┃ ┃ ┣ 📜wall_banner_red.png
 ┃ ┃ ┃ ┣ 📜wall_banner_red.png.meta
 ┃ ┃ ┃ ┣ 📜wall_banner_yellow.png
 ┃ ┃ ┃ ┣ 📜wall_banner_yellow.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_bottom_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_bottom_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_bottom_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_bottom_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_mid_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_mid_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_mid_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_mid_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_top_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_top_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_top_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_top_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_bottom_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_bottom_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_bottom_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_bottom_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_left.png
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_right.png
 ┃ ┃ ┃ ┣ 📜wall_edge_tshape_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_blue_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_basin_red_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_blue_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_mid_red_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_1.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_2.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_3.png
 ┃ ┃ ┃ ┣ 📜wall_fountain_top_3.png.meta
 ┃ ┃ ┃ ┣ 📜wall_goo.png
 ┃ ┃ ┃ ┣ 📜wall_goo.png.meta
 ┃ ┃ ┃ ┣ 📜wall_goo_base.png
 ┃ ┃ ┃ ┣ 📜wall_goo_base.png.meta
 ┃ ┃ ┃ ┣ 📜wall_hole_1.png
 ┃ ┃ ┃ ┣ 📜wall_hole_1.png.meta
 ┃ ┃ ┃ ┣ 📜wall_hole_2.png
 ┃ ┃ ┃ ┣ 📜wall_hole_2.png.meta
 ┃ ┃ ┃ ┣ 📜wall_left.png
 ┃ ┃ ┃ ┣ 📜wall_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_mid.png
 ┃ ┃ ┃ ┣ 📜wall_mid.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_front_left.png
 ┃ ┃ ┃ ┣ 📜wall_outer_front_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_front_right.png
 ┃ ┃ ┃ ┣ 📜wall_outer_front_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_mid_left.png
 ┃ ┃ ┃ ┣ 📜wall_outer_mid_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_mid_right.png
 ┃ ┃ ┃ ┣ 📜wall_outer_mid_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_top_left.png
 ┃ ┃ ┃ ┣ 📜wall_outer_top_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_outer_top_right.png
 ┃ ┃ ┃ ┣ 📜wall_outer_top_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_right.png
 ┃ ┃ ┃ ┣ 📜wall_right.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_left.png
 ┃ ┃ ┃ ┣ 📜wall_top_left.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_mid.png
 ┃ ┃ ┃ ┣ 📜wall_top_mid.png.meta
 ┃ ┃ ┃ ┣ 📜wall_top_right.png
 ┃ ┃ ┃ ┣ 📜wall_top_right.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_anime_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_anime_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_arrow.png
 ┃ ┃ ┃ ┣ 📜weapon_arrow.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_axe.png
 ┃ ┃ ┃ ┣ 📜weapon_axe.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_baton_with_spikes.png
 ┃ ┃ ┃ ┣ 📜weapon_baton_with_spikes.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_big_hammer.png
 ┃ ┃ ┃ ┣ 📜weapon_big_hammer.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_bow.png
 ┃ ┃ ┃ ┣ 📜weapon_bow.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_bow_2.png
 ┃ ┃ ┃ ┣ 📜weapon_bow_2.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_cleaver.png
 ┃ ┃ ┃ ┣ 📜weapon_cleaver.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_double_axe.png
 ┃ ┃ ┃ ┣ 📜weapon_double_axe.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_duel_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_duel_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_golden_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_golden_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_green_magic_staff.png
 ┃ ┃ ┃ ┣ 📜weapon_green_magic_staff.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_hammer.png
 ┃ ┃ ┃ ┣ 📜weapon_hammer.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_katana.png
 ┃ ┃ ┃ ┣ 📜weapon_katana.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_knife.png
 ┃ ┃ ┃ ┣ 📜weapon_knife.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_knight_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_knight_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_lavish_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_lavish_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_mace.png
 ┃ ┃ ┃ ┣ 📜weapon_mace.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_machete.png
 ┃ ┃ ┃ ┣ 📜weapon_machete.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_red_gem_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_red_gem_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_red_magic_staff.png
 ┃ ┃ ┃ ┣ 📜weapon_red_magic_staff.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_regular_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_regular_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_rusty_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_rusty_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_saw_sword.png
 ┃ ┃ ┃ ┣ 📜weapon_saw_sword.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_spear.png
 ┃ ┃ ┃ ┣ 📜weapon_spear.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_throwing_axe.png
 ┃ ┃ ┃ ┣ 📜weapon_throwing_axe.png.meta
 ┃ ┃ ┃ ┣ 📜weapon_waraxe.png
 ┃ ┃ ┃ ┣ 📜weapon_waraxe.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wizzard_f_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_hit_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_hit_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wizzard_m_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wogol_idle_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f0.png
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f0.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f1.png
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f2.png
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f3.png
 ┃ ┃ ┃ ┣ 📜wogol_run_anim_f3.png.meta
 ┃ ┃ ┃ ┣ 📜zombie_anim_f1.png
 ┃ ┃ ┃ ┣ 📜zombie_anim_f1.png.meta
 ┃ ┃ ┃ ┣ 📜zombie_anim_f10.png
 ┃ ┃ ┃ ┣ 📜zombie_anim_f10.png.meta
 ┃ ┃ ┃ ┣ 📜zombie_anim_f2.png
 ┃ ┃ ┃ ┣ 📜zombie_anim_f2.png.meta
 ┃ ┃ ┃ ┣ 📜zombie_anim_f3.png
 ┃ ┃ ┃ ┗ 📜zombie_anim_f3.png.meta
 ┃ ┃ ┣ 📜.DS_Store
 ┃ ┃ ┣ 📜0x72_DungeonTilesetII_v1.7.png
 ┃ ┃ ┣ 📜0x72_DungeonTilesetII_v1.7.png.meta
 ┃ ┃ ┣ 📜AchivementBackGround.jpg
 ┃ ┃ ┣ 📜AchivementBackGround.jpg.meta
 ┃ ┃ ┣ 📜atlas_floor-16x16.png
 ┃ ┃ ┣ 📜atlas_floor-16x16.png.meta
 ┃ ┃ ┣ 📜atlas_walls_high-16x32.png
 ┃ ┃ ┣ 📜atlas_walls_high-16x32.png.meta
 ┃ ┃ ┣ 📜atlas_walls_low-16x16.png
 ┃ ┃ ┣ 📜atlas_walls_low-16x16.png.meta
 ┃ ┃ ┣ 📜frames.meta
 ┃ ┃ ┣ 📜Player_Switch_Icon.png
 ┃ ┃ ┣ 📜Player_Switch_Icon.png.meta
 ┃ ┃ ┣ 📜pngwing.com.png
 ┃ ┃ ┣ 📜pngwing.com.png.meta
 ┃ ┃ ┣ 📜pngwing.com__1_-removebg-preview.png
 ┃ ┃ ┣ 📜pngwing.com__1_-removebg-preview.png.meta
 ┃ ┃ ┣ 📜README
 ┃ ┃ ┣ 📜README.meta
 ┃ ┃ ┣ 📜tile_list_v1.7
 ┃ ┃ ┗ 📜tile_list_v1.7.meta
 ┃ ┣ 📂__MACOSX
 ┃ ┃ ┣ 📂0x72_DungeonTilesetII_v1.7
 ┃ ┃ ┃ ┣ 📂frames
 ┃ ┃ ┃ ┃ ┣ 📜._angel_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._angel_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_demon_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._big_zombie_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._bomb_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._bomb_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._bomb_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._button_blue_down.png
 ┃ ┃ ┃ ┃ ┣ 📜._button_blue_up.png
 ┃ ┃ ┃ ┃ ┣ 📜._button_red_down.png
 ┃ ┃ ┃ ┃ ┣ 📜._button_red_up.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_empty_open_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_empty_open_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_empty_open_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_full_open_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_full_open_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_full_open_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_mimic_open_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_mimic_open_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._chest_mimic_open_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._chort_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._coin_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._coin_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._coin_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._coin_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._column.png
 ┃ ┃ ┃ ┃ ┣ 📜._column_wall.png
 ┃ ┃ ┃ ┃ ┣ 📜._crate.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._doc_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._doors_frame_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._doors_frame_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._doors_frame_top.png
 ┃ ┃ ┃ ┃ ┣ 📜._doors_leaf_closed.png
 ┃ ┃ ┃ ┃ ┣ 📜._doors_leaf_open.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_f_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._dwarf_m_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._edge_down.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_f_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._elf_m_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_big_blue.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_big_green.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_big_red.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_big_yellow.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_blue.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_green.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_red.png
 ┃ ┃ ┃ ┃ ┣ 📜._flask_yellow.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_1.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_2.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_3.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_4.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_5.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_6.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_7.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_8.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_ladder.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_spikes_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_spikes_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_spikes_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_spikes_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._floor_stairs.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._goblin_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._hole.png
 ┃ ┃ ┃ ┃ ┣ 📜._ice_zombie_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._ice_zombie_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._ice_zombie_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._ice_zombie_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._imp_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_f_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._knight_m_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._lever_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._lever_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_f_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._lizard_m_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._masked_orc_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._muddy_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._muddy_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._muddy_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._muddy_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._necromancer_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._necromancer_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._necromancer_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._necromancer_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._ogre_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_shaman_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._orc_warrior_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._pumpkin_dude_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._skelet_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._skull.png
 ┃ ┃ ┃ ┃ ┣ 📜._slug_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._slug_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._slug_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._slug_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._swampy_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._swampy_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._swampy_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._swampy_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_slug_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_slug_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_slug_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_slug_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._tiny_zombie_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._ui_heart_empty.png
 ┃ ┃ ┃ ┃ ┣ 📜._ui_heart_full.png
 ┃ ┃ ┃ ┃ ┣ 📜._ui_heart_half.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_banner_blue.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_banner_green.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_banner_red.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_banner_yellow.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_bottom_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_bottom_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_mid_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_mid_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_top_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_top_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_tshape_bottom_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_tshape_bottom_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_tshape_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_edge_tshape_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_blue_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_blue_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_blue_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_red_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_red_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_basin_red_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_blue_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_blue_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_blue_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_red_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_red_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_mid_red_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_top_1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_top_2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_fountain_top_3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_goo.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_goo_base.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_hole_1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_hole_2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_mid.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_front_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_front_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_mid_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_mid_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_top_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_outer_top_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_top_left.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_top_mid.png
 ┃ ┃ ┃ ┃ ┣ 📜._wall_top_right.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_anime_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_arrow.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_axe.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_baton_with_spikes.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_big_hammer.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_bow.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_bow_2.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_cleaver.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_double_axe.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_duel_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_golden_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_green_magic_staff.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_hammer.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_katana.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_knife.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_knight_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_lavish_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_mace.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_machete.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_red_gem_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_red_magic_staff.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_regular_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_rusty_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_saw_sword.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_spear.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_throwing_axe.png
 ┃ ┃ ┃ ┃ ┣ 📜._weapon_waraxe.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_f_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_hit_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wizzard_m_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_idle_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_idle_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_idle_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_idle_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_run_anim_f0.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_run_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_run_anim_f2.png
 ┃ ┃ ┃ ┃ ┣ 📜._wogol_run_anim_f3.png
 ┃ ┃ ┃ ┃ ┣ 📜._zombie_anim_f1.png
 ┃ ┃ ┃ ┃ ┣ 📜._zombie_anim_f10.png
 ┃ ┃ ┃ ┃ ┣ 📜._zombie_anim_f2.png
 ┃ ┃ ┃ ┃ ┗ 📜._zombie_anim_f3.png
 ┃ ┃ ┃ ┣ 📜._.DS_Store
 ┃ ┃ ┃ ┣ 📜._0x72_DungeonTilesetII_v1.7.png
 ┃ ┃ ┃ ┣ 📜._frames
 ┃ ┃ ┃ ┣ 📜._tile_list_v1.7
 ┃ ┃ ┃ ┗ 📜frames.meta
 ┃ ┃ ┣ 📜._0x72_DungeonTilesetII_v1.7
 ┃ ┃ ┗ 📜0x72_DungeonTilesetII_v1.7.meta
 ┃ ┣ 📜0x72_DungeonTilesetII_v1.7.meta
 ┃ ┗ 📜__MACOSX.meta
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
 ┣ 📂Asset_Dong
 ┃ ┣ 📂Image
 ┃ ┃ ┣ 📜2211.w030.n003.491B.p1.491.jpg
 ┃ ┃ ┣ 📜2211.w030.n003.491B.p1.491.jpg.meta
 ┃ ┃ ┣ 📜FireObastacle1.png
 ┃ ┃ ┣ 📜FireObastacle1.png.meta
 ┃ ┃ ┣ 📜FireObastacle2.png
 ┃ ┃ ┣ 📜FireObastacle2.png.meta
 ┃ ┃ ┣ 📜FireObastacle_Width1.png
 ┃ ┃ ┣ 📜FireObastacle_Width1.png.meta
 ┃ ┃ ┣ 📜FireObastacle_Width2.png
 ┃ ┃ ┣ 📜FireObastacle_Width2.png.meta
 ┃ ┃ ┣ 📜IceObastacle_Width1.png
 ┃ ┃ ┣ 📜IceObastacle_Width1.png.meta
 ┃ ┃ ┣ 📜IceObastacle_Width2.png
 ┃ ┃ ┣ 📜IceObastacle_Width2.png.meta
 ┃ ┃ ┣ 📜IceObstacle1.png
 ┃ ┃ ┣ 📜IceObstacle1.png.meta
 ┃ ┃ ┣ 📜IceObstacle2.png
 ┃ ┃ ┗ 📜IceObstacle2.png.meta
 ┃ ┗ 📜Image.meta
 ┣ 📂Asset_gw
 ┃ ┣ 📂Animations
 ┃ ┃ ┣ 📜PressAnyKey.controller
 ┃ ┃ ┣ 📜PressAnyKey.controller.meta
 ┃ ┃ ┣ 📜TextBlink.anim
 ┃ ┃ ┗ 📜TextBlink.anim.meta
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
 ┃ ┣ 📂Images
 ┃ ┃ ┣ 📜Title.png
 ┃ ┃ ┣ 📜Title.png.meta
 ┃ ┃ ┣ 📜Title_NewImage.png
 ┃ ┃ ┗ 📜Title_NewImage.png.meta
 ┃ ┣ 📂Prefabs
 ┃ ┃ ┣ 📜AchievementSlot.prefab
 ┃ ┃ ┣ 📜AchievementSlot.prefab.meta
 ┃ ┃ ┣ 📜GameScene.prefab
 ┃ ┃ ┣ 📜GameScene.prefab.meta
 ┃ ┃ ┣ 📜PlayerController.prefab
 ┃ ┃ ┗ 📜PlayerController.prefab.meta
 ┃ ┣ 📜Animations.meta
 ┃ ┣ 📜AudioAsset.meta
 ┃ ┣ 📜Images.meta
 ┃ ┗ 📜Prefabs.meta
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
 ┃ ┃ ┣ 📜GameClear.prefab
 ┃ ┃ ┣ 📜GameClear.prefab.meta
 ┃ ┃ ┣ 📜GameClearManager.prefab
 ┃ ┃ ┣ 📜GameClearManager.prefab.meta
 ┃ ┃ ┣ 📜GameOver.prefab
 ┃ ┃ ┣ 📜GameOver.prefab.meta
 ┃ ┃ ┣ 📜GameOverManager.prefab
 ┃ ┃ ┣ 📜GameOverManager.prefab.meta
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
 ┣ 📂Sprite
 ┃ ┣ 📂Map
 ┃ ┃ ┣ 📜Stage2_Back.png
 ┃ ┃ ┣ 📜Stage2_Back.png.meta
 ┃ ┃ ┣ 📜Stage3_Back .png
 ┃ ┃ ┗ 📜Stage3_Back .png.meta
 ┃ ┗ 📜Map.meta
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
 ┣ 📜0x72_DungeonTilesetII_v1.7.meta
 ┣ 📜Animations.meta
 ┣ 📜Asset_Dong.meta
 ┣ 📜Asset_gw.meta
 ┣ 📜Editor.meta
 ┣ 📜Map_Pallete.meta
 ┣ 📜Prefabs.meta
 ┣ 📜Resources.meta
 ┣ 📜Scenes.meta
 ┣ 📜Scripts.meta
 ┣ 📜Sprite.meta
 ┣ 📜TextMesh Pro.meta
 ┗ 📜Tiles.meta

 ## Trouble Shooting

 