import React from 'react';
import { Store, Home, BarChart3, User, Package, MessageSquare, CreditCard, Settings, Shield, LogOut } from 'lucide-react';
import SidebarItem from './SidebarItem';

interface SidebarProps {
  isOpen: boolean;
  onClose: () => void;
}

export default function Sidebar({ isOpen, onClose }: SidebarProps) {
  return (
    <>
      {/* Mobile backdrop */}
      {isOpen && (
        <div 
          className="fixed inset-0 bg-black/50 lg:hidden z-20"
          onClick={onClose}
        />
      )}
      
      <aside className={`
        fixed top-0 left-0 h-screen  w-64 bg-[#0A2533] text-white 
        transition-transform duration-300 ease-in-out z-30
        lg:relative lg:translate-x-0 
        ${isOpen ? 'translate-x-0' : '-translate-x-full'}
      `}>
        <div className="flex flex-col h-full p-6">
          <div className="flex items-center gap-2 mb-10">
            <Store className="w-8 h-8 text-lime-400" />
            <span className="text-xl font-semibold">Floreria Encanto</span>
          </div>

          <div className="flex-1 space-y-6">
            <div>
              <p className="text-xs text-gray-400 mb-4">MENU</p>
              <div className="space-y-2">
                <SidebarItem icon={Home} text="Overview" active />
                <SidebarItem icon={BarChart3} text="Statistics" />
                <SidebarItem icon={User} text="Customers" />
                <SidebarItem icon={Package} text="Product" />
                <SidebarItem icon={MessageSquare} text="Messages" badge="8" />
                <SidebarItem icon={CreditCard} text="Transactions" />
              </div>
            </div>

            <div>
              <p className="text-xs text-gray-400 mb-4">GENERAL</p>
              <div className="space-y-2">
                <SidebarItem icon={Settings} text="Settings" />
                <SidebarItem icon={Shield} text="Security" />
              </div>
            </div>
          </div>

          <div className="pt-6 border-t border-gray-700">
            <div className="flex items-center gap-3 text-sm">
              <img
                src="https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=64&h=64&fit=crop&crop=faces"
                alt="Profile"
                className="w-10 h-10 rounded-full"
              />
              <div>
                <p className="font-medium">Victor Ochoa</p>
                <p className="text-gray-400">john@example.com</p>
              </div>
              <LogOut className="w-5 h-5 ml-auto text-gray-400 hover:text-white cursor-pointer" />
            </div>
          </div>
        </div>
      </aside>
    </>
  );
}