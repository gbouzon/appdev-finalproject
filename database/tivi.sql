-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2021 at 06:57 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tivi`
--

-- --------------------------------------------------------

--
-- Table structure for table `budgeter`
--

CREATE TABLE `budgeter` (
  `budget_id` int(11) NOT NULL,
  `type` varchar(30) NOT NULL,
  `cost` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `date` date NOT NULL,
  `user_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `event`
--

CREATE TABLE `event` (
  `event_id` int(11) NOT NULL,
  `description` varchar(50) NOT NULL,
  `date` date NOT NULL,
  `type` varchar(6) NOT NULL,
  `user_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `event`
--

INSERT INTO `event` (`event_id`, `description`, `date`, `type`, `user_email`) VALUES
(29, 'test', '2021-11-09', 'Event', 'ga@bouzon.com.br'),
(30, 'prog pat project', '2021-11-29', 'Task', 'ga@bouzon.com.br'),
(31, 'testing user event', '2021-11-16', 'Event', 'ga@bouzon.com.br'),
(32, 'testing new user calendar', '2021-11-24', 'Event', 'newusertest3@tivi.com'),
(33, 'adding random task', '2021-11-23', 'Task', 'newusertest3@tivi.com'),
(34, 'new event', '2021-12-14', 'Event', 'ga@bouzon.com.br'),
(35, 'a task', '2021-12-22', 'Task', 'ga@bouzon.com.br'),
(36, 'bug?', '2021-12-31', 'Task', 'ga@bouzon.com.br'),
(37, 'sdada', '2021-12-16', 'Event', 'ga@bouzon.com.br'),
(38, 'unix project presentation', '2021-12-07', 'Event', 'ga@bouzon.com.br'),
(39, 'test', '2021-12-29', 'Event', 'ga@bouzon.com.br'),
(40, 'event', '2021-12-14', 'Event', 'amylee@gmail.com'),
(41, 'task', '2021-12-15', 'Task', 'amylee@gmail.com'),
(42, 'testing previous bug', '2021-12-21', 'Task', 'ga@bouzon.com.br'),
(43, 'test', '2021-12-23', 'Task', 'ga@bouzon.com.br'),
(44, 'test', '2021-12-24', 'Event', 'ga@bouzon.com.br'),
(45, 'test', '2021-12-15', 'Event', 'ga@bouzon.com.br'),
(46, 'bug', '2021-12-20', 'Event', 'ga@bouzon.com.br'),
(47, 'another bug yay', '2021-12-28', 'Event', 'ga@bouzon.com.br'),
(48, 'k im done', '2021-12-13', 'Event', 'ga@bouzon.com.br'),
(49, 'am doneeee', '2021-12-27', 'Event', 'ga@bouzon.com.br'),
(50, 'wtf', '2021-12-08', 'Event', 'ga@bouzon.com.br'),
(51, 'hells nah fam', '2021-12-13', 'Task', 'ga@bouzon.com.br'),
(52, 'ugh', '2021-12-08', 'Event', 'ga@bouzon.com.br'),
(53, 'okay but can I die now', '2021-12-15', 'Event', 'ga@bouzon.com.br'),
(54, 'k imma kms', '2021-12-19', 'Event', 'ga@bouzon.com.br'),
(55, 'aaaaaaaaaaaaaaaa', '2021-12-10', 'Event', 'ga@bouzon.com.br'),
(56, 'fuck my life', '2021-12-09', 'Event', 'ga@bouzon.com.br'),
(57, 'ewrwerew', '2021-12-16', 'Event', 'ga@bouzon.com.br'),
(58, 'k but nothing works anyways', '2021-12-14', 'Event', 'ga@bouzon.com.br');

-- --------------------------------------------------------

--
-- Table structure for table `to_do`
--

CREATE TABLE `to_do` (
  `task_id` int(11) NOT NULL,
  `description` varchar(50) NOT NULL,
  `date` date NOT NULL,
  `user_email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `to_do`
--

INSERT INTO `to_do` (`task_id`, `description`, `date`, `user_email`) VALUES
(13, 'another one', '2021-12-07', 'ga@bouzon.com.br'),
(14, 'i have to fucking study', '2021-12-08', 'amylee@gmail.com'),
(15, 'holy shit don\'t I wanna die now', '2021-12-09', 'ga@bouzon.com.br'),
(16, 'adding yet another pointless task', '2021-12-09', 'ga@bouzon.com.br');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `email` varchar(50) NOT NULL,
  `first_name` varchar(20) NOT NULL,
  `last_name` varchar(20) NOT NULL,
  `colour` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`email`, `first_name`, `last_name`, `colour`) VALUES
('amylee@gmail.com', 'Amy', 'Lee', 'Yellow'),
('anothertest@email.com', 'first', 'last', 'Green'),
('ga@bouzon.com.br', 'Giuliana', 'Bouzon', 'Green'),
('newuser2@tivi.com', 'L', 'J', 'Pink'),
('newuser40459@tivi.com', 'Another', 'Test', 'Yellow'),
('newuseragain@gmail.com', 'testig', 'again', 'LightCyan'),
('newusertest3@tivi.com', 'User', 'Test3', 'Pink'),
('newusertest@tivi.com', 'User', 'Test2', 'Purple'),
('tsstingafjsaj@tivi.com', 'lane', 'ok', 'White'),
('usertest1@tivi.com', 'User', 'One', 'Blue');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `budgeter`
--
ALTER TABLE `budgeter`
  ADD PRIMARY KEY (`budget_id`),
  ADD KEY `budget_user_fk` (`user_email`);

--
-- Indexes for table `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `user_email_fk` (`user_email`);

--
-- Indexes for table `to_do`
--
ALTER TABLE `to_do`
  ADD PRIMARY KEY (`task_id`),
  ADD KEY `user_fk` (`user_email`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `budgeter`
--
ALTER TABLE `budgeter`
  MODIFY `budget_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `event`
--
ALTER TABLE `event`
  MODIFY `event_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT for table `to_do`
--
ALTER TABLE `to_do`
  MODIFY `task_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `budgeter`
--
ALTER TABLE `budgeter`
  ADD CONSTRAINT `budget_user_fk` FOREIGN KEY (`user_email`) REFERENCES `user` (`email`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `user_email_fk` FOREIGN KEY (`user_email`) REFERENCES `user` (`email`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `to_do`
--
ALTER TABLE `to_do`
  ADD CONSTRAINT `user_fk` FOREIGN KEY (`user_email`) REFERENCES `user` (`email`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
