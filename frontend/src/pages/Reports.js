import React, { useState, useEffect } from "react";
import API from "../services/api";

function Reports() {
  const [reports, setReports] = useState([]);

  useEffect(() => {
    fetchReports();
  }, []);

  const fetchReports = async () => {
    try {
      const res = await API.get("/report");
      setReports(res.data);
    } catch (err) {
      console.error("Error fetching reports:", err);
    }
  };

  return (
    <div className="reports-page">
      <h1>ECG Reports</h1>
      <div className="reports-container">
        {reports.length === 0 ? (
          <p>No reports available</p>
        ) : (
          reports.map((report) => (
            <div key={report.report_id} className="report-card">
              <h3>Report ID: {report.report_id}</h3>
              <p>Patient ID: {report.patient_id}</p>
              <p>Status: {report.status}</p>
              <p>Date: {report.report_date}</p>
            </div>
          ))
        )}
      </div>
    </div>
  );
}

export default Reports;
