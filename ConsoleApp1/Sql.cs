namespace ConsoleApp1
{
    public static class Sql
    {
	    
	    public const string SelectData = @"
SELECT id, location1, location2, value
FROM public.test
";

        public const string Bootstrap = @"
CREATE TABLE public.test (
	id serial NOT NULL,
	location1 geography NULL,
	location2 geography NULL,
	value int4 NULL,
	CONSTRAINT pk_test PRIMARY KEY (id));

INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
INSERT INTO public.test (location1,location2,value) VALUES('POINT(-118.4079 33.9434)','POINT(-118.4079 33.9434)',98);
";
    }
}