

create table IR_Books(
id int NOT NULL IDENTITY(1,1) primary key,
std_enroll varchar(250) not null,
std_name varchar(250) not null,
std_dep varchar (250) not null,
std_sem varchar(250) not null,
std_conatct bigint not null,
std_email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,


);
select * from IR_Books

