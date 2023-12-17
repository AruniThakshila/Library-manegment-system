create table L_Table(
id int NOT NULL IDENTITY(1,1) primary key,
u_name varchar(150) not null,
pass varchar(150) not null
)

insert into L_Table(u_name,pass) values('aruni','pass');
insert into L_Table(u_name,pass) values('admin','1234');

select * from L_Table