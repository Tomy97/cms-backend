import { PrismaClient } from '@prisma/client';

const prisma = new PrismaClient();

async function main() {
  await prisma.rol.createMany({
    data: [
      {
        id: 1,
        name: 'admin',
      },
      {
        id: 2,
        name: 'user',
      }
    ]
  })

  await prisma.province.createMany({
    data: [
      {
        id: 1,
        name: 'Capital Federal'
      },
      {
        id: 2,
        name: 'Buenos Aires'
      },
      {
        id: 3,
        name: 'Córdoba'
      },
      {
        id: 4,
        name: 'Santa Fe'
      },
      {
        id: 5,
        name: 'Mendoza'
      },
      {
        id: 6,
        name: 'Tucumán'
      },
    ],
  })

  await prisma.city.createMany({
    data: [
      {
        id: 1,
        name: 'Ciudad Autónoma de Buenos Aires',
        provinceId: 1
      },
      {
        id: 2,
        name: 'Palermo',
        provinceId: 1
      },
      {
        id: 3,
        name: 'Recoleta',
        provinceId: 1
      },
      {
        id: 4,
        name: 'Villa Crespo',
        provinceId: 1
      },
      {
        id: 5,
        name: 'Caballito',
        provinceId: 1
      },
      {
        id: 6,
        name: 'Almagro',
        provinceId: 1
      },
      {
        id: 7,
        name: 'Flores',
        provinceId: 1
      },
      {
        id: 8,
        name: 'Floresta',
        provinceId: 1
      },
      {
        id: 9,
        name: 'Once',
        provinceId: 1
      },
      {
        id: 10,
        name: 'La Plata',
        provinceId: 2
      },
      {
        id: 11,
        name: 'Mar del Plata',
        provinceId: 2
      },
      {
        id: 12,
        name: 'Bahía Blanca',
        provinceId: 2
      },
      {
        id: 13,
        name: 'Tandil',
        provinceId: 2
      },
      {
        id: 14,
        name: 'Pergamino',
        provinceId: 2
      },
      {
        id: 15,
        name: 'Córdoba',
        provinceId: 3
      },
      {
        id: 16,
        name: 'Villa Carlos Paz',
        provinceId: 3
      },
      {
        id: 17,
        name: 'Rosario',
        provinceId: 4
      },
      {
        id: 18,
        name: 'Santa Fe',
        provinceId: 4
      },
      {
        id: 19,
        name: 'Mendoza',
        provinceId: 5
      },
      {
        id: 20,
        name: 'San Rafael',
        provinceId: 5
      },
      {
        id: 21,
        name: 'San Miguel de Tucumán',
        provinceId: 6
      },
      {
        id: 22,
        name: 'Tafi Viejo',
        provinceId: 6
      },
    ]
  })

  await prisma.state.updateMany({
    data: [
      {
        id: 1,
        name: 'Activo'
      },
      {
        id: 2,
        name: 'Pendiente'
      },
      {
        id: 3,
        name: 'Completado'
      },
      {
        id: 4,
        name: 'Inactivo'
      },
      {
        id: 5,
        name: 'Cancelado'
      },
    ]
  })

  await prisma.paymentMethod.createMany({
    data: [
      {
        id: 1,
        name: 'Efectivo'
      },
      {
        id: 2,
        name: 'Tarjeta de Crédito'
      },
      {
        id: 3,
        name: 'Tarjeta de Débito'
      },
      {
        id: 4,
        name: 'Transferencia Bancaria'
      },
      {
        id: 5,
        name: 'Mercado Pago'
      },
    ]
  })
  await prisma.user.create({
    data: {
      id: 1,
      name: 'admin',
      lastName: ' ',
      email: 'admin@admin.com',
      password: 'admin',
      rolId: 1,
      provinceId: 1,
      cityId: 1,
    },
  });

}

main()
  .then(() => {
    console.log('Datos insertados correctamente');
  })
  .catch((e) => {
    console.error(e);
    process.exit(1);
  })
  .finally(async () => {
    await prisma.$disconnect();
  });
