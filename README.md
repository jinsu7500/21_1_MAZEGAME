# 유니티3D 엔진을 사용한 미로찾기게임 - MAZEGAME

프로젝트 소개
------------------
Unity3D를 활용한 1인 개발게임 프로젝트이다.
단순하지만 플레이하는 재미가 있는 퍼즐장르의 게임을 개발하고자 하였다.

MazeGame은 미로찾기에 퍼즐요소를 합친 게임,
1인칭으로 개발함으로써 플레이어는 실제 미로를 탐험하는 느낌을 받을 수 있을 것이다.


기능
---------------
* 플레이어 이동 : 플레이어는 W,S,A,D키를 사용하여 전,후,좌,우로 이동할 수 있다.
* 카메라 회전 : 마우스 이동을 통해 카메라 시점을 회전시킬 수 있다.
* 상호작용 기능 : G키를 사용하여, 플레이어와 오브젝트간의 상호작용이 가능하다.
* 미로생성 기능 : 깊이 탐색 알고리즘(DFS)을 사용하여 게임을 실행할 때 마다 새롭게 미로를 생성한다.
  * DFS 알고리즘
  1) 미로는 접근이 불가능한 구역이 존재해서는 안된다. 즉, 모든 셀이 탐색가능해야 한다는 전제조건이 있다.
  2) 20 by 20의 바둑판 모양의 격자모양 셀을 생성
  3) 랜덤으로 하나의 셀을 지정, 방문기록을 한다.
  4) 선택된 셀의 인접한 셀들 중, 방문기록이 없는 셀을 찾는다.
  5) 방문하지 않은 셀들 중 하나를 선택, 사이의 벽을 제거하고 방문기록을 한다.
  6) 4~5번의 과정을 모든 셀을 방문 할 때까지 반복한다.


  



프로그램 구조도 및 흐름
---------------
![image](https://user-images.githubusercontent.com/56360477/135048201-71aa3328-f740-4643-994c-83dd9f3451cf.png)

![image](https://user-images.githubusercontent.com/56360477/135048224-9db0f9c7-fb4f-422f-9796-e58a91e340b0.png)


조작법
---------------
W : 앞으로 이동
S : 뒤로 이동
A : 왼쪽으로 이동
D : 오른쪽으로 이동
G : 오브젝트 상호작용
마우스이동 : 카메라회전


실행화면
---------------
![타이틀화면](https://user-images.githubusercontent.com/56360477/135048628-30eb7a8a-c512-420d-81f5-b132ac6ce6f9.gif)

![튜토리얼](https://user-images.githubusercontent.com/56360477/135048631-330c971c-be14-4889-b295-0410f3a90e8c.png)

![미로맵 움직임](https://user-images.githubusercontent.com/56360477/135048592-d04bd5ee-e7d1-4069-b2e7-940471b2ddc4.gif)

![복도](https://user-images.githubusercontent.com/56360477/135048608-7b88e74e-8c86-4c8b-a329-440ffa70ae61.gif)

![사망](https://user-images.githubusercontent.com/56360477/135048610-1fd8ddd9-507d-4c83-b636-b73649893c78.gif)

![엘레베이터](https://user-images.githubusercontent.com/56360477/135048616-f186160f-d709-4195-b6b0-653b2b24f104.gif)

![큐브](https://user-images.githubusercontent.com/56360477/135048619-b725987e-c953-4273-8dca-8ae151596b37.gif)

![큐브발판](https://user-images.githubusercontent.com/56360477/135048622-d42ccfdc-8ad5-4d6f-8755-772c0969deac.gif)

![큐브픽업](https://user-images.githubusercontent.com/56360477/135048624-c5f76af2-9390-4842-932d-6021805ef764.gif)

![퍼즐맵3](https://user-images.githubusercontent.com/56360477/135048657-e3f22fb5-ee47-4c47-b67f-02ec3ab10e5b.gif)

![회전](https://user-images.githubusercontent.com/56360477/135048667-db567a4c-d755-480e-88a9-ba2825a050f5.gif)

![퍼즐 올클리어](https://user-images.githubusercontent.com/56360477/135048633-b7c892d5-abee-45e2-8cc0-0ff9d825a6a7.gif)
