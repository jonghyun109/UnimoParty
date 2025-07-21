# Unimo Party (VR 닷지게임)

Firebase 기반의 사용자 정보 처리, 커스터마이징 시스템,  
Photon 네트워크 동기화, 그리고 VR 컨트롤러를 활용한  
**멀티플레이 VR 닷지 파티 게임**

---

## 📌 프로젝트 개요

| 항목     | 내용                           |
|----------|--------------------------------|
| 유형     | 기업협약 VR 프로젝트 (닷지 게임) |
| 기간     | 2025.05.08 ~ 2025.07.01 (37일) |
| 인원     | 개발 5명, 기획 4명 (총 9명)     |
| 도구     | Unity, Firebase, Photon PUN2, Meta XR |

---

## 🎮 핵심 구현 기능

### 📋 플레이어 정보 처리
- **Firebase Auth**를 활용한 회원가입 및 로그인 구현  
- **Firebase Realtime Database**를 통해  
  플레이어 데이터 저장 및 불러오기 기능 구현

### 🎛️ 옵션 및 커스터마이징
- **PlayerPrefs**를 이용한 옵션값 저장  
- **Photon Hashtable**을 활용해 인게임 오브젝트에 사용자 정보 전달  
  → 예: 사용자 스킨, 컬러, 닉네임 등

### 🧩 기타 시스템
- **플레이어 이동**: VR 기반 `Character Controller`로 구현  
- **아웃게임 UI**: Stack 구조 기반 뒤로가기 및 메뉴 복원 처리  
- **커스터마이징**: DB에서 불러온 데이터로 모델에 실시간 적용  
- **매칭 시스템**: `Photon Callbacks`를 이용한 매칭 흐름 구현

---

## 🛠️ 기술 스택

- **Unity 2022.3 (XR 지원)**
- **C#**
- **Photon PUN2 (멀티플레이어 네트워크 처리)**
- **Firebase Auth / Realtime Database**
- **Meta XR Platform SDK**

---
