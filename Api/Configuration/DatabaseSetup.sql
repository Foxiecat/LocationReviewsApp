drop database if exists LocationReviews;
create database LocationReviews;
use LocationReviews;

create user if not exists 'LocationReviewsUser'@'localhost' identified by 'L0cat1onR3views!';
create user if not exists 'LocationReviewsUser'@'%' identified by 'L0cat1onR3views!';

grant all privileges on LocationReviews.* to 'LocationReviewsUser'@'%';
grant all privileges on LocationReviews.* to 'LocationReviewsUser'@'localhost';

flush privileges;

create table Account
(
    Id binary(16) primary key,
    UserName varchar(30),
    FirstName varchar(50),
    LastName varchar(100),
    HashedPassword longtext,
    Email varchar(255)
);

create table Review
(
    Id binary(16) primary key,
    AccountId binary(16),
    Title varchar(100),
    Content longtext,
    DatePosted datetime(6),
    
    foreign key (AccountId) references Account(Id)
);