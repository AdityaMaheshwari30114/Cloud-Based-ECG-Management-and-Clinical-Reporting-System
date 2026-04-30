import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Navigation from "./components/Navigation";
import Login from "./pages/Login";
import Dashboard from "./pages/Dashboard";
import Patients from "./pages/Patients";
import Reports from "./pages/Reports";
import Devices from "./pages/Devices";

function App() {
  return (
    <Router>
      <Navigation />
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/patients" element={<Patients />} />
        <Route path="/reports" element={<Reports />} />
        <Route path="/devices" element={<Devices />} />
      </Routes>
    </Router>
  );
}

export default App;
