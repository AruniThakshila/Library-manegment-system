create table Re_Books
(
id int NOT NULL IDENTITY(1,1) primary key,
std_enroll varchar(250) not null,
std_name varchar(250) not null,
std_dep varchar (250) not null,

std_conatct bigint not null,

book_name varchar(250) not null,
book_return_date varchar(250) not null,
);

select * from Re_Books