import React from 'react';
import { Box, Package, Menu } from 'lucide-react';

interface HeaderProps {
  onMenuClick: () => void;
}

export default function Header({ onMenuClick }: HeaderProps) {
  return (
    <div className="flex flex-col gap-4 mb-8 md:flex-row md:items-center md:justify-between px-10 pt-5">
      <div className="flex items-center justify-between">
        <div>
          <h1 className="text-2xl font-semibold mb-1">Dashboard</h1>
          <p className="text-gray-500">Resumen de movimientos</p>
        </div>
        <button 
          onClick={onMenuClick}
          className="lg:hidden p-2 hover:bg-gray-100 rounded-lg"
        >
          <Menu className="w-6 h-6" />
        </button>
      </div>
      
      <div className="flex flex-col gap-4 sm:flex-row sm:items-center">
        <div className="relative">
          <input
            type="search"
            placeholder="Buscar..."
            className="w-full sm:w-80 md:w-96 pl-4 pr-10 py-2 rounded-lg border border-gray-200 focus:outline-none focus:ring-2 focus:ring-lime-400"
          />
          <Box className="w-5 h-5 text-gray-400 absolute right-3 top-2.5" />
        </div>
        <button className="flex items-center justify-center gap-2 bg-[#0A2533] text-white px-4 py-2 rounded-lg hover:bg-[#0A2533]/90">
          <Package className="w-5 h-5" />
          <span>Agregar Nuevo Producto</span>
        </button>
      </div>
    </div>
  );
}