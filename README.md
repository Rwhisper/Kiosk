# Kiosk

## 목록
1. 개요
2. 범위
3. 설계
4. 개발(OrderClient)
5. 개발(TackClient)

## 개요
### 프로젝트명
키오스크 프로그램

### 목적
C# WindowForm 기반 키오스크 프로그램 개발

## 설계
### 개발환경
개발 언어 : C# (WindowForm)
IDE : VisualStudio2019
DataBase : MySQL

### 필요 기능
1. 주문 프로그램 (Order)
- 메인페이지
- 주문
- 결제
2. 주문 받는 프로그램 (Take)
- 메인페이지
- 주문 받기

## 개발(OrderClient)
### 메인페이지
- Default Page
- 아무데나 클릭하면 화면이 넘어간다.

### 주문
- 주문 카테고리별로 tapControl로 나눈다.
- 내부는 TableLayoutPanel 로 구분
- PictureBox와 Lable 로 품목 나누기
- PictureBox_Click Event가 일어나면 선택한 품목을 장바구니에 넣고 장바구니(DataGridView)에 최신화
- 장바구니에 들어온 품목들은 품목마다 추가, 삭제가 가능
- 전체 품목 삭제 버튼
- 결제를 누르면 장바구니의 정보를 가지고 다음 페이지로 넘어간다.

### 결제
- 장바구니의 정보를 가져와서 보여주기
- 총 금액
- 포장, 매장식사 선택
- 결제시 DB에 저장

## 개발(TakeClient)
### 메인 페이지
- 프로그램이 실행될떄 DB에 저장된 모든 결제 기록을 보여준다.
- 실시간으로 OrderCLient에 주문이 들어오면 주문받는 페이지로 넘어간다.
### 주문 받는 화면
- OrderClient에서 주문이 넘어 오면 보여주는 페이지
- 주문 번호, 주문 제품, 제품 별 합산가격, 제품 별 주문량을 보여준다.
- 확인을 누르면 창 닫기
