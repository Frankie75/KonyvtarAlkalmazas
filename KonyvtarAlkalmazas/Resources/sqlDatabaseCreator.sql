create table konyvek (
isbn		bigint				primary key,
szerzo		varchar(50),
cim			varchar(100)	not null,
megjelenes	date			not null
);

create table kolcsonzesek (
id			int				primary key identity,
kolcsonzo	varchar(50)		not null,
konyv		bigint,
hatarido	date,
foreign key (konyv) references konyvek
);


