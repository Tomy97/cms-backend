/*
  Warnings:

  - The primary key for the `category` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `categoryId` on the `category` table. All the data in the column will be lost.
  - You are about to drop the column `userUserId` on the `category` table. All the data in the column will be lost.
  - You are about to alter the column `userId` on the `category` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - The primary key for the `city` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `cityId` on the `city` table. All the data in the column will be lost.
  - The primary key for the `client` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `clientId` on the `client` table. All the data in the column will be lost.
  - You are about to alter the column `userId` on the `client` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `cityId` on the `client` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `stateId` on the `client` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - The primary key for the `order` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `clientClientId` on the `order` table. All the data in the column will be lost.
  - You are about to drop the column `idOrder` on the `order` table. All the data in the column will be lost.
  - You are about to drop the column `userUserId` on the `order` table. All the data in the column will be lost.
  - You are about to alter the column `userId` on the `order` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `clientId` on the `order` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `productId` on the `order` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `stateId` on the `order` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `paymentMethodId` on the `order` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - The primary key for the `paymentmethod` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `paymentMethodId` on the `paymentmethod` table. All the data in the column will be lost.
  - The primary key for the `product` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `productId` on the `product` table. All the data in the column will be lost.
  - You are about to drop the column `userUserId` on the `product` table. All the data in the column will be lost.
  - You are about to alter the column `userId` on the `product` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - You are about to alter the column `categoryId` on the `product` table. The data in that column could be lost. The data in that column will be cast from `Char(36)` to `Int`.
  - The primary key for the `state` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `stateId` on the `state` table. All the data in the column will be lost.
  - The primary key for the `user` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - You are about to drop the column `userId` on the `user` table. All the data in the column will be lost.
  - A unique constraint covering the columns `[id]` on the table `Category` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `City` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `Client` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `Order` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `PaymentMethod` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `Product` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `State` will be added. If there are existing duplicate values, this will fail.
  - A unique constraint covering the columns `[id]` on the table `User` will be added. If there are existing duplicate values, this will fail.
  - Added the required column `id` to the `Category` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `City` table without a default value. This is not possible if the table is not empty.
  - Added the required column `provinceId` to the `City` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `Client` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `Order` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `PaymentMethod` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `Product` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `State` table without a default value. This is not possible if the table is not empty.
  - Added the required column `id` to the `User` table without a default value. This is not possible if the table is not empty.
  - Added the required column `lastName` to the `User` table without a default value. This is not possible if the table is not empty.
  - Added the required column `name` to the `User` table without a default value. This is not possible if the table is not empty.
  - Added the required column `rolId` to the `User` table without a default value. This is not possible if the table is not empty.

*/
-- DropForeignKey
ALTER TABLE `category` DROP FOREIGN KEY `Category_userUserId_fkey`;

-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_cityId_fkey`;

-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_stateId_fkey`;

-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_userId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_clientClientId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_paymentMethodId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_productId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_stateId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_userUserId_fkey`;

-- DropForeignKey
ALTER TABLE `product` DROP FOREIGN KEY `Product_categoryId_fkey`;

-- DropForeignKey
ALTER TABLE `product` DROP FOREIGN KEY `Product_userUserId_fkey`;

-- DropIndex
DROP INDEX `Category_userUserId_fkey` ON `category`;

-- DropIndex
DROP INDEX `Client_cityId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Client_stateId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Client_userId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Order_clientClientId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_paymentMethodId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_productId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_stateId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_userUserId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Product_categoryId_fkey` ON `product`;

-- DropIndex
DROP INDEX `Product_userUserId_fkey` ON `product`;

-- AlterTable
ALTER TABLE `category` DROP PRIMARY KEY,
    DROP COLUMN `categoryId`,
    DROP COLUMN `userUserId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    MODIFY `userId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `city` DROP PRIMARY KEY,
    DROP COLUMN `cityId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    ADD COLUMN `provinceId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `client` DROP PRIMARY KEY,
    DROP COLUMN `clientId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    MODIFY `userId` INTEGER NOT NULL,
    MODIFY `cityId` INTEGER NOT NULL,
    MODIFY `stateId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `order` DROP PRIMARY KEY,
    DROP COLUMN `clientClientId`,
    DROP COLUMN `idOrder`,
    DROP COLUMN `userUserId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    MODIFY `userId` INTEGER NOT NULL,
    MODIFY `clientId` INTEGER NOT NULL,
    MODIFY `productId` INTEGER NOT NULL,
    MODIFY `stateId` INTEGER NOT NULL,
    MODIFY `paymentMethodId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `paymentmethod` DROP PRIMARY KEY,
    DROP COLUMN `paymentMethodId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `product` DROP PRIMARY KEY,
    DROP COLUMN `productId`,
    DROP COLUMN `userUserId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    MODIFY `userId` INTEGER NOT NULL,
    MODIFY `categoryId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `state` DROP PRIMARY KEY,
    DROP COLUMN `stateId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    ADD PRIMARY KEY (`id`);

-- AlterTable
ALTER TABLE `user` DROP PRIMARY KEY,
    DROP COLUMN `userId`,
    ADD COLUMN `id` INTEGER NOT NULL AUTO_INCREMENT,
    ADD COLUMN `lastName` VARCHAR(191) NOT NULL,
    ADD COLUMN `name` VARCHAR(191) NOT NULL,
    ADD COLUMN `rolId` INTEGER NOT NULL,
    ADD PRIMARY KEY (`id`);

-- CreateTable
CREATE TABLE `Province` (
    `id` INTEGER NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(191) NOT NULL,

    UNIQUE INDEX `Province_id_key`(`id`),
    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- CreateTable
CREATE TABLE `Rol` (
    `id` INTEGER NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(191) NOT NULL,

    UNIQUE INDEX `Rol_id_key`(`id`),
    PRIMARY KEY (`id`)
) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- CreateIndex
CREATE UNIQUE INDEX `Category_id_key` ON `Category`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `City_id_key` ON `City`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `Client_id_key` ON `Client`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `Order_id_key` ON `Order`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `PaymentMethod_id_key` ON `PaymentMethod`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `Product_id_key` ON `Product`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `State_id_key` ON `State`(`id`);

-- CreateIndex
CREATE UNIQUE INDEX `User_id_key` ON `User`(`id`);

-- AddForeignKey
ALTER TABLE `User` ADD CONSTRAINT `User_rolId_fkey` FOREIGN KEY (`rolId`) REFERENCES `Rol`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_userId_fkey` FOREIGN KEY (`userId`) REFERENCES `User`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_cityId_fkey` FOREIGN KEY (`cityId`) REFERENCES `City`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_stateId_fkey` FOREIGN KEY (`stateId`) REFERENCES `State`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Product` ADD CONSTRAINT `Product_userId_fkey` FOREIGN KEY (`userId`) REFERENCES `User`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Product` ADD CONSTRAINT `Product_categoryId_fkey` FOREIGN KEY (`categoryId`) REFERENCES `Category`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Category` ADD CONSTRAINT `Category_userId_fkey` FOREIGN KEY (`userId`) REFERENCES `User`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_paymentMethodId_fkey` FOREIGN KEY (`paymentMethodId`) REFERENCES `PaymentMethod`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_stateId_fkey` FOREIGN KEY (`stateId`) REFERENCES `State`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_productId_fkey` FOREIGN KEY (`productId`) REFERENCES `Product`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_userId_fkey` FOREIGN KEY (`userId`) REFERENCES `User`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_clientId_fkey` FOREIGN KEY (`clientId`) REFERENCES `Client`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `City` ADD CONSTRAINT `City_provinceId_fkey` FOREIGN KEY (`provinceId`) REFERENCES `Province`(`id`) ON DELETE RESTRICT ON UPDATE CASCADE;
