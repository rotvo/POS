// src/pages/Overview.jsx o Dashboard.jsx
import React, { useEffect, useState } from 'react';
import { BarChart3, CreditCard, User } from 'lucide-react';
import StatCard from '../components/StatCard';
import TransactionList from '../components/TransactionList';
import SalesReport from '../components/SalesReport';
import UsersList from '../components/UsersList';
import { UserData } from "../components/users";
import { ApiResponse } from '../types/apiResponse';
import axios from 'axios';

export default function Overview() {
  const [users, setUsers] = useState<UserData[]>([])


  const fetchUsers = async () => {
    try {
      const response = await axios.get<ApiResponse<UserData>>(
        "https://localhost:7292/api/Clients/Select"
      );
      setUsers(response.data.data.items);
      console.log(response.data.data.items)
    } catch (error) {
      console.error("Error fetching users:", error);
    }
  };
  useEffect(() => {
    fetchUsers();
  }, []);


  return (
    <div className="p-4 md:p-8 min-h-screen pb-20">
      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4 md:gap-6 mb-8">
        <StatCard
          title="Ingresos Netos"
          value="$193,000"
          change={{ value: "35%", type: "increase" }}
          icon={BarChart3}
        />
        <StatCard
          title="Retorno Total"
          value="$32,000"
          change={{ value: "24%", type: "decrease" }}
          icon={CreditCard}
        />
        <StatCard
          title="Usuarios Activos"
          value="11,200"
          change={{ value: "12%", type: "increase" }}
          icon={User}
        />
      </div>

      <div className="grid grid-cols-1 lg:grid-cols-2 gap-4 md:gap-6 mb-8">
        <TransactionList />
        <SalesReport />
      </div>

      <div className="w-full">
        <UsersList users={users} />
      </div>
    </div>
  );
}