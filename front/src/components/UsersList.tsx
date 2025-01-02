import { UserData } from "./users";

interface UsersListProps {
  users: UserData[];
}

export default function UsersList({ users }: UsersListProps) {
  return (
    <div className="bg-white rounded-xl shadow-sm">
      <div className="p-6 border-b border-gray-100">
        <div className="flex justify-between items-center">
          <h2 className="text-lg font-semibold">Recent Customers</h2>
          <button className="text-gray-400 hover:text-gray-600">•••</button>
        </div>
      </div>
      <div className="divide-y divide-gray-100">
        {users.map((user) => (
          <div key={user.id} className="p-6 hover:bg-gray-50">
            <div className="flex items-center justify-between">
              <div className="flex items-center gap-4">
                <img
                  src={user.avatar || '/api/placeholder/40/40'}
                  alt={user.nombre || 'User'}
                  className="w-10 h-10 rounded-full"
                />
                <div>
                  <h3 className="font-medium">{user.nombre || 'N/A'}</h3>
                  <p className="text-sm text-gray-500">{user.numeroWhatsapp || 'No email'}</p>
                </div>
              </div>
              <div className="hidden md:block text-right">
                <p className="text-sm font-medium">{user.totalSpent || '$0'}</p>
                <p className="text-sm text-gray-500">Total Gastado</p>
              </div>
              <div className="text-right">
                <p className="text-sm font-medium">{user.recentPurchases || 0}</p>
                <p className="text-sm text-gray-500">Pedidos Recientes</p>
              </div>
              <div className="hidden md:block text-right">
                <p className="text-sm text-gray-500">Ultima compra</p>
                <p className="text-sm">{user.lastPurchase || 'Never'}</p>
              </div>
            </div>
          </div>
        ))}
        {users.length === 0 && (
          <div className="p-6 text-center text-gray-500">
            No customers found
          </div>
        )}
      </div>
    </div>
  );
}