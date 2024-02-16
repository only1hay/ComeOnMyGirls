# ComeOnMyGirls
 
##프로젝트 소개
타워디펜스 장르에 미소녀 컨셉을 결합하여 만든 게임입니다.
TIL을 쓰지 않은 유저와 쓰게 하려는 매니저몬스터들 간의 치열한 혈투를 그렸습니다.

###개발 기간
24.02.09 ~ 24.02.16

####멤버구성
Unity 3기 5조 
허아영 : 게임진행상태표시 및 구매,업그레이드 UI
이광재 : 타워 생성 및 업그레이드, 타워 공격로직과 속성
손현웅 : 게임 맵 생성 및 배치, 게임오버 및 승리조건, 게임매니저 관리
오승희 : 적의 움직임과 스폰, 적의 속성

#####개발환경
Unity 2022.3.2f1


######주요기능
게임 맵 생성 및 배치
-맵 경로 설정, 적 이동경로 설정

타워 생성 및 업그레이드
- 타워포지션 클릭 시 세 종류의 타워 배치 가능
- 각 타워의 데미지에 비례한 비용을 지불하여 업그레이드

적의 움직임과 스폰
- 경로를 따라 이동하는 적 구현
- 일정한 시간 간격으로 세 종류의 적이 스폰
- 라운드가 올라가면 적 능력치도 상승되어 스폰

타워 공격로직
- 적을 감지하여 일정 범위 안에 들어오면 공격
- 타워종류별로 공격방식 변화

적과 타워의 체력 및 공격력
- 각 세종류의 적과 타워의 속성 관리 시스템
- 타워의 데미지 계산 및 적이 공격당했을 경우 체력 감소
- 적 종류별로 각기 다른 체력 및 이동속도

자원관리
- 적 처치 시 적 종류에 따른 자원 획득
- 타워 구매 및 업그레이드 시 자원 소모

게임 진행 상태 표시
- UI요소를 활용하여 현재 '작성한 TIL의 수', '자원', '스코어', '라운드' 표기
- 구매 및 업그레이드 UI를 통한 타워 정보 표시

게임오버 및 승리 조건
- 적이 본진에 다다를 시 '작성한 TIL 수'가 증가하며 40개가 채워질 경우 게임 오버
- 한 라운드 당 40마리의 적을 처치할 시 다음 라운드 진출, 5라운드까지 방어 시 게임 승리
- 현재 기록 표시 및 최고기록 저장

#######시연영상
