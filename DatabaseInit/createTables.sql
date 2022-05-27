CREATE TABLE user_credentials
(
   username character varying(50) NOT NULL,
   password_hash character varying(64) NOT NULL,
   PRIMARY KEY (username)
);

CREATE TABLE user_data
(
   username character varying(50) NOT NULL,
   real_name character varying(50),
   surname character varying(50),
   license numeric(6, 0),
   dob date,
   sex sex,
   is_admin boolean NOT NULL DEFAULT false,
   CONSTRAINT user_data_pkey PRIMARY KEY (username),
   CONSTRAINT usernameConnection FOREIGN KEY (username)
       REFERENCES public.user_credentials (username) MATCH SIMPLE
       ON UPDATE NO ACTION
       ON DELETE NO ACTION
       NOT VALID
);

CREATE TABLE vehicles
(
   id integer NOT NULL,
   brand character varying(50) NOT NULL,
   model character varying(50) NOT NULL,
   fuel_type fuel_type NOT NULL,
   seats numeric NOT NULL,
   price_per_day numeric NOT NULL,
   vclass vehicle_class NOT NULL,
   PRIMARY KEY (id)
);

CREATE TABLE reservations
(
   reservation_id integer NOT NULL,
   vehicle_id integer NOT NULL,
   username character varying(50) NOT NULL,
   date_from date NOT NULL,
   date_to date NOT NULL,
   PRIMARY KEY (reservation_id),
   CONSTRAINT user_connect FOREIGN KEY (username)
       REFERENCES public.user_credentials (username) MATCH SIMPLE
       ON UPDATE NO ACTION
       ON DELETE NO ACTION
       NOT VALID,
   CONSTRAINT v_conn FOREIGN KEY (vehicle_id)
       REFERENCES public.vehicles (id) MATCH SIMPLE
       ON UPDATE NO ACTION
       ON DELETE CASCADE
       NOT VALID
);