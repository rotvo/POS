import React from 'react';
import { LucideIcon } from 'lucide-react';

interface SidebarItemProps {
  icon: LucideIcon;
  text: string;
  active?: boolean;
  badge?: string;
}

export default function SidebarItem({ icon: Icon, text, active, badge }: SidebarItemProps) {
  return (
    <div className={`flex items-center gap-3 p-2 rounded-lg cursor-pointer ${active ? 'bg-lime-400/10 text-lime-400' : 'hover:bg-white/5'}`}>
      <Icon className="w-5 h-5" />
      <span>{text}</span>
      {badge && (
        <span className="ml-auto bg-lime-400 text-[#0A2533] text-xs font-medium px-2 py-0.5 rounded-full">
          {badge}
        </span>
      )}
    </div>
  );
}