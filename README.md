<div align="center">


# [<img width="60" height="60" alt="Youtube_logo" src="https://github.com/user-attachments/assets/8e31fdca-af1b-4ebc-b2c9-cdb9983454b4" />](https://www.youtube.com/watch?v=CY5KfPY-0xk)  Unimo Party VR

### 우주선을 직접 조종해 광물을 채굴하면서 적을 피하는 VR 닷지 액션!

<br>

<table>
  <tr>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/5c728b91-60a0-49e9-af64-751164c919ec" alt="원작 게임 플레이" width="100%"/>
      <br/>
      <b>원작 게임 플레이</b>
    </td>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/350b93a3-45a6-4b82-bc8f-8f409e8557b4" alt="게임 로고" width="100%"/>
      <br/>
      <b>게임 로고</b>
    </td>
    <td align="center" width="33%">
      <img src="https://github.com/user-attachments/assets/c04bed13-8672-4e3a-9b9a-4c8797620eaf" alt="VR 플레이" width="100%"/>
      <br/>
      <b>VR 플레이</b>
    </td>
  </tr>
</table>



<br>
<br>

⭐ **원작 유니모 별모험을 기업과 협업하여 리메이크 하였음**

⭐ **기본적인 탑뷰, 솔로 게임에서 1인칭 멀티 게임으로 전환하여 게임의 스릴감과 재미를 극대화 한게 특징**

</div>

<br>
<br>
<br>


---

</div>

<br>
<br>

## 📋 목차

- [게임 소개](#-게임-소개)
- [주요 스크립트](#-주요-스크립트)
  - [오디오 시스템](#-오디오-시스템)
  - [인증 및 데이터베이스](#-인증-및-데이터베이스)
  - [플레이어 이동 및 컨트롤](#-플레이어-이동-및-컨트롤)
  - [플레이어 회전 시스템](#-플레이어-회전-시스템)
  - [로비 및 매치메이킹](#-로비-및-매치메이킹)
  - [플레이어 설정 및 UI](#-플레이어-설정-및-ui)
  - [옵션 시스템](#️-옵션-시스템)
  - [상점 시스템](#-상점-시스템)
  - [게임플레이](#-게임플레이)
  - [기타](#-기타)
- [기술 스택](#-주요-기술-스택)
- [참고사항](#-참고사항)
- [개발자](#-개발자)

<br>
<br>

---

<br>
<br>

## 🎯 게임 소개

**유니모 별모험 VR**은 우주선을 직접 조종해 광물을 채굴하면서 적을 피하는 VR 닷지 액션 게임입니다.  
원작 탑뷰 게임을 1인칭 멀티플레이어 VR 게임으로 전환하여 스릴감과 재미를 극대화했습니다.

<br>
<br>

---

<br>
<br>

# 📁 YJH Scripts

> UnimoParty 프로젝트의 YJH 폴더 스크립트 모음입니다.

<br>
<br>

---

## 💻 주요 스크립트

<br>

## 🎵 오디오 시스템

<br>

### [`AudioManager.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/AudioManager.cs)

**💡 기능**: BGM 및 SFX를 관리하는 싱글톤 오디오 매니저

**📌 주요 메서드**:
- `PlayBGM(string name)`: BGM 재생
- `PlaySFX(string name)`: 효과음 재생
- `SetBGMVolume(float v)`: BGM 볼륨 조절
- `SetSFXVolume(float v)`: SFX 볼륨 조절

**✨ 특징**: DontDestroyOnLoad로 씬 전환 시에도 유지됨

<br>
<br>

---

<br>
<br>

## 🔐 인증 및 데이터베이스

<br>

### [`FirebaseAuthMgr.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/FirebaseAuthMgr.cs)

**💡 기능**: Firebase 인증 및 실시간 데이터베이스 관리

**📌 주요 기능**:
- 이메일/비밀번호 기반 회원가입 및 로그인
- 닉네임 설정 및 관리
- 유저 데이터 저장/로드 (게임 머니 등)

**📌 주요 메서드**:
- `Login()`: 로그인 처리
- `Register()`: 회원가입 처리
- `SaveUserData<T>()`: 유저 데이터 저장
- `LoadUserDataAsync<T>()`: 유저 데이터 로드

<br>
<br>

---

<br>
<br>

## 🎮 플레이어 이동 및 컨트롤

<br>

### [`JoystickController.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/JoystickController.cs)

**💡 기능**: VR 조이스틱을 이용한 플레이어 이동 컨트롤

**✨ 특징**:
- XR Joystick을 사용한 전후좌우 이동
- IFreeze 인터페이스 구현 (얼음 폭탄 등에 의한 이동 정지)
- 조이스틱 선택 시 컨트롤러 모델 전환

**📌 주요 메서드**:
- `OnJoystickMoveY(float value)`: 전후 이동
- `OnJoystickMoveX(float value)`: 좌우 이동
- `Freeze(bool IsFreeze)`: 이동 정지/해제

<br>

### [`HeadDash.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/HeadDash.cs)

**💡 기능**: VR 헤드셋 기울임으로 대시하는 기능

**✨ 특징**:
- 헤드셋을 일정 각도 이상 기울이면 해당 방향으로 대시
- 쿨다운 시스템 포함
- IFreeze 인터페이스 구현

**📌 주요 속성**:
- `dashAngle`: 대시 발동 각도 (기본 30도)
- `dashDistance`: 대시 거리
- `dashCooldown`: 쿨다운 시간

<br>
<br>

---

<br>
<br>

## 🔄 플레이어 회전 시스템

<br>

### [`PlayerRotateSet.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/PlayerRotateSet.cs)

**💡 기능**: 플레이어 시야에 따른 우주선 회전 (제한 범위 기반)

**✨ 특징**:
- 카메라가 좌우 60도 범위를 벗어나면 자동으로 우주선 회전
- 범위 안으로 돌아오면 회전 멈춤

<br>

### [`RotateSetting.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/RotateSetting.cs)

**💡 기능**: 카메라 방향에 따른 우주선 회전 설정

**✨ 특징**: 
- 카메라 각도가 60도 이상 벗어나면 회전 시작
- PlayerRotateSet과 유사하지만 다른 로직 구현

<br>
<br>

---

<br>
<br>

## 🏠 로비 및 매치메이킹

<br>

### [`LobbyManager.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/LobbyManager.cs)

**💡 기능**: 로비 UI 관리 및 Photon 네트워크 매치메이킹 시스템

**📌 주요 기능**:
- PVE/PVP 모드 선택
- 방 생성 및 참가
- 코드를 통한 방 입장
- 자동 매치메이킹 시스템
- Ready 시스템 및 게임 시작

**📌 주요 메서드**:
- `CreatRoom()`: 방 생성
- `MatchmakingButton()`: 매치메이킹 시작/중지
- `CodeJoinRoom()`: 코드로 방 입장
- `StartGameButton()`: 게임 시작

<br>

### [`TestPvP.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/TestPvP.cs)

**💡 기능**: 개발자/디자이너용 PvP 테스트 로비

**✨ 특징**: 
- 개발팀과 디자인팀 전용 테스트 룸
- 간단한 방 생성 및 게임 시작 기능

<br>
<br>

---

<br>
<br>

## 👤 플레이어 설정 및 UI

<br>

### [`PlayerPanel.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/PlayerPanel.cs)

**💡 기능**: 로비에서 플레이어 패널 UI 관리

**📌 표시 정보**:
- 닉네임
- Ready 상태
- 방장 여부

<br>

### [`PlayerAvatarSetup.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/PlayerAvatarSetup.cs)

**💡 기능**: 인게임에서 플레이어 캐릭터 및 우주선 설정

**✨ 특징**:
- Photon RPC를 통한 네트워크 동기화
- 캐릭터와 우주선 인덱스 기반 생성
- 로컬 플레이어의 캐릭터는 렌더러 비활성화 (1인칭 시점)

<br>
<br>

---

<br>
<br>

## ⚙️ 옵션 시스템

<br>

### [`OptionManager.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/OptionManager.cs)

**💡 기능**: 게임 옵션 UI 관리 및 설정 저장/로드

**📌 옵션 항목**:
- Vignette 크기 (멀미 방지)
- BGM 볼륨
- SFX 볼륨
- 회전 방식 (Smooth/Snap)
- Snap 회전 각도 (30/60/90도)
- Smooth 회전 속도

**📌 주요 메서드**:
- `OptionSave()`: PlayerPrefs에 옵션 저장
- `OptionLoad()`: PlayerPrefs에서 옵션 로드
- `ValueChange()`: 슬라이더 값 변경 시 실시간 적용

<br>

### [`OptionData.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/OptionData.cs)

**💡 기능**: 옵션 데이터를 저장하는 정적 클래스

**✨ 특징**: 씬 간 옵션 데이터 공유

<br>

### [`LoadPlayerSetting.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/LoadPlayerSetting.cs)

**💡 기능**: 인게임 시작 시 저장된 플레이어 옵션 설정 로드

**📌 적용 항목**:
- Vignette 크기
- 회전 방식 및 속도

<br>
<br>

---

<br>
<br>

## 🛒 상점 시스템

<br>

### [`ShopManager.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/ShopManager.cs)

**💡 기능**: 캐릭터 및 우주선 상점 관리

**📌 주요 기능**:
- 캐릭터 및 우주선 미리보기
- 구매 시스템 (Firebase 연동)
- 구매 정보 저장 및 로드
- 선택한 캐릭터/우주선 정보를 Photon CustomProperties에 저장

**📌 주요 메서드**:
- `CharacterPreview(int index)`: 캐릭터 미리보기
- `ShipPreview(int index)`: 우주선 미리보기
- `BuyShip(SpaceShip selectedShip)`: 우주선 구매
- `SaveSelectedIndices()`: 선택 정보 저장

<br>
<br>

---

<br>
<br>

## 🎮 게임플레이

<br>

### [`SpawnTest.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/SpawnTest.cs)

**💡 기능**: PVE 모드 몬스터 스폰 시스템

**✨ 특징**:
- 마스터 클라이언트만 스폰 관리
- Photon RPC를 통한 네트워크 동기화
- 지정된 영역 내 랜덤 위치 스폰
- 게임 종료 시 자동으로 스폰 중지

**📌 주요 속성**:
- `spawnList`: 스폰할 프리팹과 개수 리스트
- `areaCenter/areaSize`: 스폰 영역 설정

<br>
<br>

---

<br>
<br>

## 📦 기타

<br>

### [`FakeRoom.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/FakeRoom.cs)

**💡 기능**: 방과 플레이어 정보를 담는 데이터 클래스

**✨ 용도**: 테스트 또는 UI 표시용 가상 방 데이터

<br>

### [`PrefabCache.cs`](https://github.com/jonghyun109/UnimoParty/blob/Develop_main/Assets/Scripts/YJH/PrefabCache.cs)

**⚠️ 상태**: 빈 스크립트 (미구현)

<br>
<br>

<br>
<br>

---

<br>
<br>

## 🔧 주요 기술 스택

<br>

- 🎯 **Unity XR Interaction Toolkit**: VR 인터랙션
- 🌐 **Photon PUN2**: 멀티플레이어 네트워킹
- 🔥 **Firebase**: 인증 및 데이터베이스
- 📝 **TextMeshPro**: UI 텍스트

<br>
<br>

---

<br>
<br>

## 📝 참고사항

<br>

💡 **멀티플레이어**
- 대부분의 스크립트가 Photon PUN2를 사용하여 멀티플레이어 기능 구현

💡 **상태 이상 효과**
- IFreeze 인터페이스를 통해 얼음 폭탄 등의 상태 이상 효과 구현

💡 **데이터 지속성**
- DontDestroyOnLoad 패턴을 사용하여 씬 전환 시에도 데이터 유지

<br>
<br>

---

<br>
<br>

<div align="center">

## 👨‍💻 개발자

<br>

**YJH (윤종현)**

<br>
<br>

[![GitHub](https://img.shields.io/badge/GitHub-jonghyun109-181717?style=for-the-badge&logo=github)](https://github.com/jonghyun109/UnimoParty)

<br>

**📌 모든 스크립트 링크는 위의 GitHub 저장소에서 확인할 수 있습니다.**

</div>

<br>
<br>

