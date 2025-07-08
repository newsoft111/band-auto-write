-- Band Auto Write 애플리케이션을 위한 테이블 생성 스크립트
-- 데이터베이스: newsoft

-- 사용자 테이블 (user)
CREATE TABLE `user` (
  `id` varchar(50) NOT NULL COMMENT '사용자 아이디',
  `pass` varchar(255) NOT NULL COMMENT '비밀번호 (MD5 해시)',
  `date` date NOT NULL COMMENT '서비스 만료일',
  `band_session` varchar(255) DEFAULT NULL COMMENT 'Band 세션 토큰',
  `fb_session` varchar(255) DEFAULT NULL COMMENT 'Facebook 세션 토큰',
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP COMMENT '생성일시',
  `updated_at` timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '수정일시',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='사용자 정보 테이블';

-- SMS 발송 로그 테이블 (sms_log)
CREATE TABLE `sms_log` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '고유 ID',
  `user_id` varchar(50) NOT NULL COMMENT '사용자 아이디',
  `tel` varchar(20) NOT NULL COMMENT '수신번호',
  `callback` varchar(20) NOT NULL COMMENT '회신번호',
  `message` text NOT NULL COMMENT '발송 메시지',
  `subject` varchar(100) DEFAULT NULL COMMENT '메시지 제목 (LMS용)',
  `send_date` datetime DEFAULT NULL COMMENT '예약 발송일시',
  `result` varchar(50) DEFAULT NULL COMMENT '발송 결과',
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP COMMENT '생성일시',
  PRIMARY KEY (`id`),
  KEY `idx_user_id` (`user_id`),
  KEY `idx_send_date` (`send_date`),
  FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='SMS 발송 로그 테이블';

-- Band 게시글 테이블 (band_posts)
CREATE TABLE `band_posts` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '고유 ID',
  `user_id` varchar(50) NOT NULL COMMENT '사용자 아이디',
  `title` varchar(200) DEFAULT NULL COMMENT '게시글 제목',
  `content` text NOT NULL COMMENT '게시글 내용',
  `band_id` varchar(100) DEFAULT NULL COMMENT 'Band 그룹 ID',
  `post_id` varchar(100) DEFAULT NULL COMMENT 'Band 게시글 ID',
  `status` enum('pending','success','failed') DEFAULT 'pending' COMMENT '발송 상태',
  `error_message` text DEFAULT NULL COMMENT '오류 메시지',
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP COMMENT '생성일시',
  `updated_at` timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '수정일시',
  PRIMARY KEY (`id`),
  KEY `idx_user_id` (`user_id`),
  KEY `idx_status` (`status`),
  KEY `idx_created_at` (`created_at`),
  FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Band 게시글 테이블';

-- Facebook 게시글 테이블 (facebook_posts)
CREATE TABLE `facebook_posts` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '고유 ID',
  `user_id` varchar(50) NOT NULL COMMENT '사용자 아이디',
  `content` text NOT NULL COMMENT '게시글 내용',
  `page_id` varchar(100) DEFAULT NULL COMMENT 'Facebook 페이지 ID',
  `post_id` varchar(100) DEFAULT NULL COMMENT 'Facebook 게시글 ID',
  `status` enum('pending','success','failed') DEFAULT 'pending' COMMENT '발송 상태',
  `error_message` text DEFAULT NULL COMMENT '오류 메시지',
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP COMMENT '생성일시',
  `updated_at` timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '수정일시',
  PRIMARY KEY (`id`),
  KEY `idx_user_id` (`user_id`),
  KEY `idx_status` (`status`),
  KEY `idx_created_at` (`created_at`),
  FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Facebook 게시글 테이블';

-- 시스템 설정 테이블 (system_config)
CREATE TABLE `system_config` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT '고유 ID',
  `config_key` varchar(100) NOT NULL COMMENT '설정 키',
  `config_value` text DEFAULT NULL COMMENT '설정 값',
  `description` varchar(255) DEFAULT NULL COMMENT '설정 설명',
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP COMMENT '생성일시',
  `updated_at` timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT '수정일시',
  PRIMARY KEY (`id`),
  UNIQUE KEY `uk_config_key` (`config_key`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='시스템 설정 테이블';

-- 기본 시스템 설정 데이터 삽입
INSERT INTO `system_config` (`config_key`, `config_value`, `description`) VALUES
('sms_api_key', '', 'SMS 발송 API 키'),
('sms_callback', '', 'SMS 회신번호'),
('band_api_url', '', 'Band API URL'),
('facebook_api_url', '', 'Facebook API URL'),
('max_posts_per_day', '100', '일일 최대 게시글 수'),
('session_timeout', '3600', '세션 타임아웃 (초)');

-- 샘플 사용자 데이터 (테스트용)
INSERT INTO `user` (`id`, `pass`, `date`) VALUES
('admin', MD5('admin123'), DATE_ADD(CURDATE(), INTERVAL 1 YEAR)),
('test', MD5('test123'), DATE_ADD(CURDATE(), INTERVAL 30 DAY));

-- 인덱스 추가
CREATE INDEX `idx_user_date` ON `user` (`date`);
CREATE INDEX `idx_sms_log_created_at` ON `sms_log` (`created_at`);
CREATE INDEX `idx_band_posts_band_id` ON `band_posts` (`band_id`);
CREATE INDEX `idx_facebook_posts_page_id` ON `facebook_posts` (`page_id`); 