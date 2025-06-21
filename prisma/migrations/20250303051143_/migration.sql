/*
  Warnings:

  - The primary key for the `category` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `city` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `client` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `order` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `paymentmethod` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `product` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `state` table will be changed. If it partially fails, the table could be left without primary key constraint.
  - The primary key for the `user` table will be changed. If it partially fails, the table could be left without primary key constraint.

*/
-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_cityId_fkey`;

-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_stateId_fkey`;

-- DropForeignKey
ALTER TABLE `client` DROP FOREIGN KEY `Client_userId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_paymentMethodId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_productId_fkey`;

-- DropForeignKey
ALTER TABLE `order` DROP FOREIGN KEY `Order_stateId_fkey`;

-- DropForeignKey
ALTER TABLE `product` DROP FOREIGN KEY `Product_categoryId_fkey`;

-- DropIndex
DROP INDEX `Client_cityId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Client_stateId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Client_userId_fkey` ON `client`;

-- DropIndex
DROP INDEX `Order_paymentMethodId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_productId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Order_stateId_fkey` ON `order`;

-- DropIndex
DROP INDEX `Product_categoryId_fkey` ON `product`;

-- AlterTable
ALTER TABLE `category` DROP PRIMARY KEY,
    ADD COLUMN `userUserId` CHAR(36) NULL,
    MODIFY `categoryId` CHAR(36) NOT NULL,
    MODIFY `userId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`categoryId`);

-- AlterTable
ALTER TABLE `city` DROP PRIMARY KEY,
    MODIFY `cityId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`cityId`);

-- AlterTable
ALTER TABLE `client` DROP PRIMARY KEY,
    MODIFY `clientId` CHAR(36) NOT NULL,
    MODIFY `userId` CHAR(36) NOT NULL,
    MODIFY `cityId` CHAR(36) NOT NULL,
    MODIFY `stateId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`clientId`);

-- AlterTable
ALTER TABLE `order` DROP PRIMARY KEY,
    ADD COLUMN `clientClientId` CHAR(36) NULL,
    ADD COLUMN `userUserId` CHAR(36) NULL,
    MODIFY `idOrder` CHAR(36) NOT NULL,
    MODIFY `userId` CHAR(36) NOT NULL,
    MODIFY `clientId` CHAR(36) NOT NULL,
    MODIFY `productId` CHAR(36) NOT NULL,
    MODIFY `stateId` CHAR(36) NOT NULL,
    MODIFY `paymentMethodId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`idOrder`);

-- AlterTable
ALTER TABLE `paymentmethod` DROP PRIMARY KEY,
    MODIFY `paymentMethodId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`paymentMethodId`);

-- AlterTable
ALTER TABLE `product` DROP PRIMARY KEY,
    ADD COLUMN `userUserId` CHAR(36) NULL,
    MODIFY `productId` CHAR(36) NOT NULL,
    MODIFY `userId` CHAR(36) NOT NULL,
    MODIFY `categoryId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`productId`);

-- AlterTable
ALTER TABLE `state` DROP PRIMARY KEY,
    MODIFY `stateId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`stateId`);

-- AlterTable
ALTER TABLE `user` DROP PRIMARY KEY,
    MODIFY `userId` CHAR(36) NOT NULL,
    ADD PRIMARY KEY (`userId`);

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_userId_fkey` FOREIGN KEY (`userId`) REFERENCES `User`(`userId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_cityId_fkey` FOREIGN KEY (`cityId`) REFERENCES `City`(`cityId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Client` ADD CONSTRAINT `Client_stateId_fkey` FOREIGN KEY (`stateId`) REFERENCES `State`(`stateId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Product` ADD CONSTRAINT `Product_categoryId_fkey` FOREIGN KEY (`categoryId`) REFERENCES `Category`(`categoryId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Product` ADD CONSTRAINT `Product_userUserId_fkey` FOREIGN KEY (`userUserId`) REFERENCES `User`(`userId`) ON DELETE SET NULL ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Category` ADD CONSTRAINT `Category_userUserId_fkey` FOREIGN KEY (`userUserId`) REFERENCES `User`(`userId`) ON DELETE SET NULL ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_productId_fkey` FOREIGN KEY (`productId`) REFERENCES `Product`(`productId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_stateId_fkey` FOREIGN KEY (`stateId`) REFERENCES `State`(`stateId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_paymentMethodId_fkey` FOREIGN KEY (`paymentMethodId`) REFERENCES `PaymentMethod`(`paymentMethodId`) ON DELETE RESTRICT ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_userUserId_fkey` FOREIGN KEY (`userUserId`) REFERENCES `User`(`userId`) ON DELETE SET NULL ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE `Order` ADD CONSTRAINT `Order_clientClientId_fkey` FOREIGN KEY (`clientClientId`) REFERENCES `Client`(`clientId`) ON DELETE SET NULL ON UPDATE CASCADE;
