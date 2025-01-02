import React from 'react';
import { LucideIcon } from 'lucide-react';

interface StatCardProps {
  title: string;
  value: string;
  change: {
    value: string;
    type: 'increase' | 'decrease';
  };
  icon: LucideIcon;
}

export default function StatCard({ title, value, change, icon: Icon }: StatCardProps) {
  return (
    <div className="bg-white rounded-xl p-6 shadow-sm">
      <div className="flex justify-between items-start mb-4">
        <h3 className="text-gray-500 font-medium">{title}</h3>
        <Icon className="w-5 h-5 text-gray-400" />
      </div>
      <p className="text-3xl font-semibold mb-2">{value}</p>
      <p className={`text-sm ${change.type === 'increase' ? 'text-green-500' : 'text-red-500'}`}>
        {change.type === 'increase' ? '+' : '-'}{change.value} desde el ultimo mes
      </p>
    </div>
  );
}