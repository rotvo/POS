import React from 'react';

export default function SalesReport() {
  return (
    <div className="bg-white rounded-xl p-6 shadow-sm">
      <div className="flex justify-between items-center mb-6">
        <h2 className="text-lg font-semibold">Reportes de Ventas</h2>
        <button className="text-gray-400 hover:text-gray-600">•••</button>
      </div>
      <div className="space-y-4">
        <div>
          <div className="flex justify-between mb-2">
            <p className="text-gray-600">Product Launched</p>
            <p className="font-medium">233</p>
          </div>
          <div className="w-full bg-gray-100 rounded-full h-2">
            <div className="bg-lime-400 h-2 rounded-full" style={{ width: '70%' }}></div>
          </div>
        </div>
        <div>
          <div className="flex justify-between mb-2">
            <p className="text-gray-600">Ongoing Products</p>
            <p className="font-medium">23</p>
          </div>
          <div className="w-full bg-gray-100 rounded-full h-2">
            <div className="bg-lime-400 h-2 rounded-full" style={{ width: '30%' }}></div>
          </div>
        </div>
        <div>
          <div className="flex justify-between mb-2">
            <p className="text-gray-600">Products Sold</p>
            <p className="font-medium">482</p>
          </div>
          <div className="w-full bg-gray-100 rounded-full h-2">
            <div className="bg-lime-400 h-2 rounded-full" style={{ width: '90%' }}></div>
          </div>
        </div>
      </div>
    </div>
  );
}