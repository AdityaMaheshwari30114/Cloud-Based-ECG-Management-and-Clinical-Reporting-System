import React from "react";
import PatientList from "../components/PatientList";

function Patients() {
  return (
    <div className="patients-page">
      <h1>Patients Management</h1>
      <button className="btn-primary">Add New Patient</button>
      <PatientList />
    </div>
  );
}

export default Patients;
