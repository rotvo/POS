import React from 'react';
import { Box, Smartphone, Coffee } from 'lucide-react';
import TransactionItem from './TransactionItem';

export default function TransactionList() {
  return (
    <div className="bg-white rounded-xl p-6 shadow-sm">
      <div className="flex justify-between items-center mb-6">
        <h2 className="text-lg font-semibold">Compras Recientes</h2>
        <button className="text-gray-400 hover:text-gray-600">•••</button>
      </div>
      <div className="space-y-1">
        
        <TransactionItem
          icon={Box}
          title="PlayStation 5"
          date="Jul 12th 2024"
          id="0JWEJS7ISNC"
          status="Pending"
        />
        <TransactionItem
          icon={Smartphone}
          title="iPhone 15 Pro Max"
          date="Jul 12th 2024"
          id="0JWEJS7ISNC"
          status="Completed"
        />
        <TransactionItem
          icon={Coffee}
          title="Starbucks"
          date="Jul 12th 2024"
          id="0JWEJS7ISNC"
          status="Completed"
        />
      </div>
    </div>
  );
}