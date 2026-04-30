CREATE TABLE ROLE (
    role_id SERIAL PRIMARY KEY,
    role_name VARCHAR(50)
);

CREATE TABLE USERS (
    user_id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100),
    role_id INT REFERENCES ROLE(role_id)
);

CREATE TABLE PATIENT (
    patient_id SERIAL PRIMARY KEY,
    patient_name VARCHAR(100),
    age INT,
    managed_by INT REFERENCES USERS(user_id)
);

CREATE TABLE DEVICE (
    device_id SERIAL PRIMARY KEY,
    device_name VARCHAR(100)
);

CREATE TABLE ECG_REPORT (
    report_id SERIAL PRIMARY KEY,
    patient_id INT REFERENCES PATIENT(patient_id),
    device_id INT REFERENCES DEVICE(device_id),
    status VARCHAR(50),
    report_date DATE
);

CREATE TABLE AUDIT_LOG (
    log_id SERIAL PRIMARY KEY,
    user_id INT REFERENCES USERS(user_id),
    activity TEXT
);
