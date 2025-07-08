<!DOCTYPE html>
<html lang="ko">

<head>	
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="viewport" content="width=device-width, height=device-height, initial-scale=0.7, user-scalable=0, minimum-scale=0.7, maximum-scale=0.7">
	<meta name="format-detection" content="telephone=no, address=no, email=no" />
	<meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1">
	<title>New-IDC</title>	
	<link rel="stylesheet" type="text/css" href="../css/reset_code.css" /> 
	<link rel="stylesheet" href="../font-awesome-4.4.0/css/font-awesome.min.css">
	<link rel="stylesheet" type="text/css" href="../css/normalize.css" />
	<link rel="stylesheet" type="text/css" href="../css/default.css" />
	<link rel="stylesheet" type="text/css" href="../css/sub.css" />
	<link rel="stylesheet" href="../css/idangerous.swiper.css">
	<script src="../js/idangerous.swiper-2.1.min.js"></script> 

	<script src="../js/respond.src.js"></script>	
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
	<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.min.js"></script>		
	<script src="../js/html5shiv-printshiv.js"></script>
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>


	

	<!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
	<!--[if lt IE 9]>
		<script src="http://cherryweb.co.kr/guide/js/html5shiv.js"></script>
		<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->
	<!--[if lt IE 8]>
		<link href="http://cherryweb.co.kr/css/bootstrap-ie7.css" rel="stylesheet">
	<![endif]-->

	<!-- main nav -->
		<script type="text/javascript">
         $(function(){
	     $("nav ul.sub").hide();
		 $("nav ul.menu li").hover(function(){
		    $("ul:not(:animated)",this).slideDown("fast");
			},
			function(){
			   $("ul",this).slideUp("fast");
			});
      });	
   </script>

</head>

<body>
	<!--
	<header>
		<div id="wrap">
			<ul id="top_nav">
				<li style="border-left:1px solid #e4e4e4;" onclick="top.location.href='#';" class="login"><i class="fa fa-sign-in"></i>로그인</li>
				<li><i class="fa fa-pencil-square-o"></i></i>회원가입</li>
			</ul>
		</div>
	</header>
	-->
	<!-- 상단 메뉴 시작 -->
	<nav>		
		<div id="wrap">
			<h1><a href="/" style="color:#fff;">New-IDC</a></h1>
			<ul class="menu">
				<li>
					<a href="/">HOME</a>
				</li>
				<li>
					<a href="/sub/sub_01_1.php">웹호스팅</a>
					<ul class="sub">
						<li><a href="/sub/sub_01_1.php">SSD 웹호스팅</a></li>
						<!-- <li><a href="//sub/sub_01_2.php">일본 웹호스팅 신청하기</a></li> -->
					</ul>
				</li>
				<li>
					<a href="/sub/sub_02_1.php">가상서버</a>
					<ul class="sub">
						<li><a href="/sub/sub_02_1.php">리눅스 SSD 가상서버</a></li>
						<!-- <li><a href="/sub/sub_02_2.php">리눅스 가상서버 신청하기</a></li> -->
						<li><a href="/sub/sub_02_3.php">윈도우 SSD 가상서버</a></li>
						<!-- <li><a href="/sub/sub_02_4.php">윈도우 가상서버 신청하기</a></li> -->
					</ul>
				</li>
				<li>
					<a href="/sub/sub_03_1.php">단독서버</a>
					<ul class="sub">
						<li><a href="/sub/sub_03_1.php">리눅스 단독서버</a></li>
						<li><a href="/sub/sub_03_2.php">윈도우 단독서버</a></li>
						<!-- <li><a href="/sub/sub_03_3.php">일본 단독서버 상담/신청</a></li> -->
					</ul>
				</li>
				<li>
					<a href="/sub/sub_04_1.php">해외 테마 호스팅</a>
					<ul class="sub">
						<li><a href="/sub/sub_04_1.php">일반 호스팅</a></li>
						<li><a href="/sub/sub_04_2.php">블로그 호스팅</a></li>
						<li><a href="/sub/sub_04_3.php">커뮤니티 호스팅</a></li>
						<li><a href="/sub/sub_04_4.php">성인 호스팅</a></li>
						<li><a href="/sub/sub_04_5.php">쇼핑몰 호스팅</a></li>
						<!-- <li><a href="/sub/sub_04_6.php">해외 테마호스팅 신청서</a></li> -->
					</ul>
				</li>
				<!--
				<li>
					<a href="/sub/sub_05_1.php">사이트구축</a>
					<ul class="sub">
						<li><a href="/sub/sub_05_1.php">사이트구축</a></li>
						<li><a href="/sub/sub_05_2.php">사이트구축 상담</a></li>
					</ul>
				</li>
				-->
				<li>
					<a href="/sub/sub_06_1.php">고객지원</a>
					<ul class="sub">
						<li><a href="/sub/sub_06_1.php">공지사항</a></li>
						<!-- <li><a href="/sub/sub_06_2.php">1:1문의</a></li> -->
					</ul>
				</li>
		   </ul>
		</div>
	</nav>
	<!-- 상단 메뉴 끝 -->