import React from 'react';
import { LucideIcon } from 'lucide-react';

interface TransactionItemProps {
  icon: LucideIcon;
  title: string;
  date: string;
  id: string;
  status: 'Completed' | 'Pending';
}

export default function TransactionItem({ icon: Icon, title, date, id, status }: TransactionItemProps) {
  return (
    <div className="flex items-center gap-4 p-4 hover:bg-gray-50 rounded-lg">
      <div className="p-2 bg-gray-100 rounded-lg">
        <Icon className="w-6 h-6 text-gray-600" />
      </div>
      <div className="min-w-0 flex-1">
        <p className="font-medium truncate">{title}</p>
        <p className="text-sm text-gray-500">{date}</p>
      </div>
      <div className="text-right">
        <p className="text-sm text-gray-500 hidden sm:block">{id}</p>
        <p className={`text-sm ${status === 'Completed' ? 'text-green-600' : 'text-orange-600'}`}>
          {status}
        </p>
      </div>
    </div>
  );
}