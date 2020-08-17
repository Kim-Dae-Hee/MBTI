# 개요

![개요](images/개요.png)

MBTI는 나에 대해 더 잘 알고 싶어 하는 밀레니얼, Z 세대의 성향과 만나 하나의 트렌드로 떠오르고 있습니다.
저희도 재미로 하는 성격 검사에 흥미가 있어서 이 프로그램을 만들게 되었습니다. MBTI를 실제로 검사할 수 있도록 구현했고 만 번의 시뮬레이션을 통해 16개 성격이 어떻게 분포되는지 확인하는 프로그램입니다.

# 사용기술
## 언어
* C# 3.0+

## 프레임워크
* .NetFramework
* EntityFramework
* Winform

## 데이터베이스
* MSSQL Server 2019

## Thrid Party Control
* DevExrpess Winform

# 데이터베이스 설계

![데이터베이스설계](images/데이터베이스설계.png)

* Test와 Question은 다대다 관계이기 때문에 Response 매핑 테이블을 만들었습니다.

# 설명

## 1. 구현 내용

### 1-1 StartForm

![Start Form](images/StartForm.png)

* 사용자는 이름과 이메일을 입력하면 MBTI 테스트를 시작할 수 있습니다.
검사 시작 버튼을 클릭하면 User 테이블에 이름과 이메일이 저장됩니다.

### 1-2 TestForm

![Test Form](images/TestForm.png)

* 사용자는 1 ~ 48번까지 각각 점수를 매길 수 있습니다.
사용자가 테스트를 진행하다가 이전 문제로 돌아와서 점수를 바꿀 수도 있기에 한 문제마다 Response 테이블에 점수를 저장해줬습니다.


![마지막 번호](images/마지막_번호.png)

* 48번 문항으로 가면 완료 버튼이 생기게 되고 클릭하면 검사가 완료됩니다.

### 1-3 ResultForm

![Pie Chart 결과](images/PieChart_결과.png)

* 검사가 완료되면 사용자는 4개 영역의 결과를 Pie Chart로 확인할 수 있습니다.

![Table 결과](images/Table_결과.png)

* 또한 TabControl을 이용하여 하나의 Form에서 2개의 페이지를 사용했습니다.
* 이 페이지는 사용자의 결과를 보다 자세히 알려줍니다.

### 1-4 SimulationResultForm

* 저희는 문득 여러 번 검사를 해보면서 10000번의 시뮬레이션을 돌리면 어떠한 결과가 나올지 궁금해졌습니다.

![만번 시뮬레이션](images/만번_시뮬레이션.png)

* 따라서 10000번의 시뮬레이션을 돌려봤습니다.

![10000번 시뮬레이션](images/10000번_시뮬레이션.png)

* 약 10000번 시뮬레이션의 결과가 Test 테이블에 저장된 사진입니다.

![시뮬레이션](images/시뮬레이션.png)

* 10000번의 시뮬레이션 결과를 쉽게 확인하기 위해서 Bar Chart를 사용했습니다.
* 결과를 확인해보니 저희의 예상과는 다르게 고르게 분포되지 않았음을 알 수 있었습니다.

![바인딩](images/바인딩.png)

* Pie Chart나 Bar Chart를 나타내기 위해서는 Chart Control에 배열이나 컬렉션(List) 같은 데이터를 Chart에 바인딩해주면 됩니다.

## 2. 문제해결 과정


### 2-1 UserControl 사용 

#### 증상
* 처음에 12개의 점수 버튼을 Form 하나에서 해결하려 했지만 관리하기 복잡했습니다. 

#### 해결
* 따라서 User Control -> User Control -> Form으로 이벤트를 통해 데이터를 전달해주니 복잡도를 줄일 수 있었습니다.

![이벤트 생성](images/이벤트_생성.png)

### 2-2 테스트 도중 점수를 DB에 저장 문제

#### 증상
* 처음에는 모든 테스트가 끝나면 검사 결과를 DB에 저장하려 했으나 이러면 검사 도중 이전 문항으로 돌아가서 점수를 다시 매기거나 중간에 튕기게 되면 데이터가 날아가는 경우가 발생했습니다. 

#### 해결
* 따라서 한 문항의 점수를 매기고 다음 페이지로 넘길 때마다 Response 테이블에 데이터를 저장했습니다.

![Response](images/Response.png)

### 2-3 연쇄삭제 문제 

#### 증상
* DB 테이블의 데이터를 삭제할 때 테이블 간 연쇄삭제가 설정되어 있지 않아서 삭제하는데 어려움을 느꼈습니다.

#### 해결
* DB 테이블 간 관계 속성에서 연쇄삭제 기능을 추가해서 해결했습니다.

![연쇄 삭제](images/연쇄_삭제.png)





